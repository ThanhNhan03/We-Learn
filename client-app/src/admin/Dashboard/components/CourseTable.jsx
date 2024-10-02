import React, { useState, useEffect } from 'react';
import {
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Paper,
  Button,
  Select,
  MenuItem,
  Box,
  Dialog,
  DialogActions,
  DialogContent,
  DialogContentText,
  DialogTitle,
  TextField,
  InputAdornment
} from '@mui/material';
import SearchIcon from '@mui/icons-material/Search';
import CourseDialog from './CreateandUpdateCourseDialog';
import sampleCourses from './DataCourse';

const CourseTable = ({ darkMode }) => {
  const [courses, setCourses] = useState(sampleCourses);
  const [openDialog, setOpenDialog] = useState(false);
  const [selectedCourse, setSelectedCourse] = useState(null);
  const [openDeleteDialog, setOpenDeleteDialog] = useState(false);
  const [courseToDelete, setCourseToDelete] = useState(null);
  const [filterSubject, setFilterSubject] = useState('All');
  const [searchQuery, setSearchQuery] = useState('');
  const [dialogAction, setDialogAction] = useState('');
  const [newSubject, setNewSubject] = useState('');
  const [openSubjectDialog, setOpenSubjectDialog] = useState(false);

  const [subjects, setSubjects] = useState([
    { id: 1, name: "Mathematics" },
    { id: 2, name: "Physics" },
    { id: 3, name: "Chemistry" }
  ]);
  const [allSubjects, setAllSubjects] = useState(["All", "Mathematics", "Physics", "Chemistry"]);

  useEffect(() => {
    const subjectNames = subjects.map(subject => subject.name);
    setAllSubjects(["All", ...subjectNames]);
  }, [subjects]);

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

  const handleAddSubject = () => {
    if (newSubject) {
      const newSubjectObj = { 
        id: Date.now(),
        name: newSubject 
      };
      setSubjects(prevSubjects => [...prevSubjects, newSubjectObj]);
      setNewSubject('');
      setOpenSubjectDialog(false);
    }
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
      <Button variant="contained" color="secondary" onClick={() => setOpenSubjectDialog(true)} style={{ margin: '16px' }}>
        Add Category Subject
      </Button>

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
          {allSubjects.map((subject, index) => (
            <MenuItem key={index} value={subject}>{subject}</MenuItem>
          ))}
        </Select>
      </Box>

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
      <CourseDialog 
        open={openDialog} 
        onClose={handleCloseDialog} 
        onSave={handleSaveCourse} 
        courseData={selectedCourse} 
        action={dialogAction}
        subjects={subjects}
      />
      
      <Dialog
        open={openSubjectDialog}
        onClose={() => setOpenSubjectDialog(false)}
        aria-labelledby="subject-dialog-title"
      >
        <DialogTitle id="subject-dialog-title">{"Add Category"}</DialogTitle>
        <DialogContent>
          <DialogContentText>
            Enter new category name:
          </DialogContentText>
          <TextField
            autoFocus
            margin="dense"
            label="New Subject"
            type="text"
            fullWidth
            variant="outlined"
            value={newSubject}
            onChange={(e) => setNewSubject(e.target.value)}
          />
        </DialogContent>
        <DialogActions>
          <Button onClick={() => setOpenSubjectDialog(false)} color="primary">
            Cancel
          </Button>
          <Button onClick={handleAddSubject} color="primary">
            Add
          </Button>
        </DialogActions>
      </Dialog>

      <Dialog
        open={openDeleteDialog}
        onClose={handleCancelDelete}
        aria-labelledby="alert-dialog-title"
        aria-describedby="alert-dialog-description"
      >
        <DialogTitle id="alert-dialog-title">{"Confirm course deletion"}</DialogTitle>
        <DialogContent>
          <DialogContentText id="alert-dialog-description">
            Are you sure you want to delete the course "{courseToDelete?.name}"?
          </DialogContentText>
        </DialogContent>
        <DialogActions>
          <Button onClick={handleCancelDelete} color="primary">
            Cancel
          </Button>
          <Button onClick={handleConfirmDelete} color="primary" autoFocus>
            Confirm
          </Button>
        </DialogActions>
      </Dialog>
    </TableContainer>
  );
};

export default CourseTable;