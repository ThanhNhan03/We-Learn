import React, { useState } from 'react';
import { Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper, Button, Select, MenuItem, Box, Dialog, DialogActions, DialogContent, DialogContentText, DialogTitle, TextField, InputAdornment } from '@mui/material';
import SearchIcon from '@mui/icons-material/Search';
import CourseDialog from './CreateandUpdateCourseDialog';
import AdminCourseDetail from './AdminCourseDetail';
import AdminLectureDetail from './AdminLectureDetail';

const sampleCourses = [
  {
    id: 1,
    subject: "Mathematics",
    code: "MATH101",
    name: "Introduction to Mathematics",
    price: 100,
    startDate: "2023-09-01",
    endDate: "2023-12-15",
    status: "public",
    description: "An introductory course to basic mathematical concepts.",
    resources: "Textbook, Online exercises",
    image: "https://example.com/math101.jpg"
  },
  {
    id: 2,
    subject: "Physics",
    code: "PHYS101",
    name: "Fundamentals of Physics",
    price: 120,
    startDate: "2023-09-01",
    endDate: "2023-12-15",
    status: "Active",
    description: "A comprehensive introduction to physics principles.",
    resources: "Lab equipment, Simulation software",
    image: "https://example.com/phys101.jpg"
  },
  {
    id: 3,
    subject: "Chemistry",
    code: "CHEM101",
    name: "Basic Chemistry",
    price: 110,
    startDate: "2023-09-01",
    endDate: "2023-12-15",
    status: "static",
    description: "Explore the fundamental principles of chemistry.",
    resources: "Chemical kit, Safety equipment",
    image: "https://example.com/chem101.jpg"
  },
];

const CourseTable = ({ darkMode }) => {
  const [courses, setCourses] = useState(sampleCourses);
  const [openDialog, setOpenDialog] = useState(false);
  const [selectedCourse, setSelectedCourse] = useState(null);
  const [viewCourseDetail, setViewCourseDetail] = useState(false);
  const [viewLectureDetail, setViewLectureDetail] = useState(false);
  const [selectedLecture, setSelectedLecture] = useState(null);
  const [openDeleteDialog, setOpenDeleteDialog] = useState(false);
  const [courseToDelete, setCourseToDelete] = useState(null);
  const [filterSubject, setFilterSubject] = useState('All');
  const [searchQuery, setSearchQuery] = useState('');
  const [dialogAction, setDialogAction] = useState('');

  const handleAddCourse = () => {
    const newCourse = {
      subject: "",
      code: "",
      name: "",
      price: 0,
      startDate: new Date().toISOString().split('T')[0],
      endDate: new Date().toISOString().split('T')[0],
      status: "Active"
    };
    setSelectedCourse(newCourse);
    setDialogAction('add');
    setOpenDialog(true);
  };

  const handleEditCourse = (course) => {
    setSelectedCourse(course);
    setDialogAction('edit');
    setOpenDialog(true);
  };

  const handleCloseDialog = () => {
    setOpenDialog(false);
  };

  const handleSaveCourse = (courseData) => {
    if (selectedCourse && selectedCourse.id) {
      setCourses(courses.map(course => 
        course.id === selectedCourse.id ? { ...course, ...courseData } : course
      ));
    } else {
      const newCourse = {
        ...courseData,
        id: Date.now(),
      };
      setCourses([...courses, newCourse]);
    }
    handleCloseDialog();
  };

  const handleDeleteCourse = (courseId) => {
    const course = courses.find(course => course.id === courseId);
    setCourseToDelete(course);
    setOpenDeleteDialog(true);
  };

  const handleConfirmDelete = () => {
    setCourses(courses.filter(course => course.id !== courseToDelete.id));
    setOpenDeleteDialog(false);
    setCourseToDelete(null);
  };

  const handleCancelDelete = () => {
    setOpenDeleteDialog(false);
    setCourseToDelete(null);
  };

  const handleViewCourseDetail = (course) => {
    setSelectedCourse(course);
    setViewCourseDetail(true);
  };

  const handleViewLectureDetail = (lecture) => {
    setSelectedLecture(lecture);
    setViewLectureDetail(true);
  };

  const handleBackToTable = () => {
    setViewCourseDetail(false);
    setViewLectureDetail(false);
    setSelectedCourse(null);
    setSelectedLecture(null);
  };

  const filteredCourses = courses.filter((course) => 
    (filterSubject === 'All' || course.subject === filterSubject) &&
    course.subject.toLowerCase().includes(searchQuery.toLowerCase())
  );

  return (
    <TableContainer component={Paper}>
      <Button variant="contained" color="primary" onClick={handleAddCourse} style={{ margin: '16px' }}>
        Add Course
      </Button>

      {/* Search and Filter Controls */}
      {!viewCourseDetail && !viewLectureDetail && (
        <Box display="flex" justifyContent="space-between" alignItems="center" style={{ margin: '16px' }}>
          <TextField 
            label="Search Subject" 
            variant="outlined" 
            value={searchQuery} 
            onChange={(e) => setSearchQuery(e.target.value)} 
            InputProps={{
              startAdornment: (
                <InputAdornment position="start">
                  <SearchIcon />
                </InputAdornment>
              ),
            }}
          />
          <Select
            value={filterSubject}
            onChange={(e) => setFilterSubject(e.target.value)}
            displayEmpty
          >
            <MenuItem value="All">All Subjects</MenuItem>
            <MenuItem value="Mathematics">Mathematics</MenuItem>
            <MenuItem value="Physics">Physics</MenuItem>
            <MenuItem value="Chemistry">Chemistry</MenuItem>
          </Select>
        </Box>
      )}

      {viewCourseDetail ? (
        <Box>
          <Button variant="contained" color="secondary" onClick={handleBackToTable}>
            Back to Course List
          </Button>
          <AdminCourseDetail course={selectedCourse} onViewLecture={handleViewLectureDetail} />
        </Box>
      ) : viewLectureDetail ? (
        <Box>
          <Button variant="contained" color="secondary" onClick={handleBackToTable}>
            Back to Course List
          </Button>
          <AdminLectureDetail lecture={selectedLecture} onClose={handleBackToTable} />
        </Box>
      ) : (
        <Table>
          <TableHead>
            <TableRow>
              <TableCell>Subject</TableCell>
              <TableCell>Course Code</TableCell>
              <TableCell>Course Name</TableCell>
              <TableCell>Price</TableCell>
              <TableCell>Start Date</TableCell>
              <TableCell>End Date</TableCell>
              <TableCell>Status</TableCell>
              <TableCell>Actions</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {filteredCourses.map((course) => (
              <TableRow key={course.id}>
                <TableCell>{course.subject}</TableCell>
                <TableCell>{course.code}</TableCell>
                <TableCell>{course.name}</TableCell>
                <TableCell>{course.price}</TableCell>
                <TableCell>{course.startDate}</TableCell>
                <TableCell>{course.endDate}</TableCell>
                <TableCell>{course.status}</TableCell>
                <TableCell>
                  <Select
                    value=""
                    onChange={(event) => {
                      const operation = event.target.value;
                      switch (operation) {
                        case 'delete':
                          handleDeleteCourse(course.id);
                          break;
                        case 'view':
                          handleViewCourseDetail(course);
                          break;
                        default:
                          break;
                      }
                    }}
                    displayEmpty
                  >
                    <MenuItem value="" disabled>Operation</MenuItem>
                    <MenuItem value="delete">Delete</MenuItem>
                    <MenuItem value="view">View Details</MenuItem>
                  </Select>
                </TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      )}
      <CourseDialog 
        open={openDialog} 
        onClose={handleCloseDialog} 
        onSave={handleSaveCourse} 
        courseData={selectedCourse} 
        action={dialogAction}
      />
      <Dialog
        open={openDeleteDialog}
        onClose={handleCancelDelete}
        aria-labelledby="alert-dialog-title"
        aria-describedby="alert-dialog-description"
      >
        <DialogTitle id="alert-dialog-title">{"Xác nhận xóa khóa học"}</DialogTitle>
        <DialogContent>
          <DialogContentText id="alert-dialog-description">
            Bạn có chắc chắn muốn xóa khóa học "{courseToDelete?.name}" không?
          </DialogContentText>
        </DialogContent>
        <DialogActions>
          <Button onClick={handleCancelDelete} color="primary">
            Hủy
          </Button>
          <Button onClick={handleConfirmDelete} color="primary" autoFocus>
            Xác nhận
          </Button>
        </DialogActions>
      </Dialog>
    </TableContainer>
  );
};

export default CourseTable;