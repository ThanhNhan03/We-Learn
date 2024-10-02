import React, { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';
import {
  Container,
  Typography,
  Button,
  Grid,
  Paper,
  Table,
  TableBody,
  TableCell,
  TableContainer,
  TableHead,
  TableRow,
  Box,
  Select,
  MenuItem,
  Dialog,
  DialogTitle,
  DialogContent,
  DialogActions,
} from '@mui/material';
import DateRangeIcon from '@mui/icons-material/DateRange';
import ImageIcon from '@mui/icons-material/Image';
import DescriptionIcon from '@mui/icons-material/Description';
import ArrowDropDownIcon from '@mui/icons-material/ArrowDropDown';
import { styled } from '@mui/material/styles';
import CreateandUpdateCourseDialog from './CreateandUpdateCourseDialog';
import CreateLectureDialog from './CreateandUpdateLectureDialog';
import LectureDetail from './AdminLectureDetail';
import CreateandUpdateExerciseDialog from './CreateandUpdateExerciseDialog';
import AdminLectureDetail from './AdminLectureDetail';

const StyledSelect = styled(Select)(({ theme }) => ({
  '&:hover .MuiOutlinedInput-notchedOutline': {
    borderColor: theme.palette.primary.main,
  },
  '&.Mui-focused .MuiOutlinedInput-notchedOutline': {
    borderColor: theme.palette.primary.main,
  },
}));

const AdminCourseDetail = () => {
  const { id } = useParams();
  const [course, setCourse] = useState(null);
  const [lectures, setLectures] = useState([]);
  const [assignments, setAssignments] = useState([]);
  const [openEditDialog, setOpenEditDialog] = useState(false);
  const [openCreateDialog, setOpenCreateDialog] = useState(false);
  const [selectedLecture, setSelectedLecture] = useState(null);
  const [openLectureDetailDialog, setOpenLectureDetailDialog] = useState(false);
  const [openCreateExerciseDialog, setOpenCreateExerciseDialog] = useState(false);
  const [openDeleteConfirmDialog, setOpenDeleteConfirmDialog] = useState(false);
  const [lectureToDelete, setLectureToDelete] = useState(null);

  useEffect(() => {
    if (!course) {
      // Fetch course details if not provided as prop
      // For now, we'll use mock data
      setCourse({
        id: parseInt(id),
        subject: "Math and Logic",
        code: "MaL080238",
        name: "Linear Algebra 18.06",
        description: "This course covers matrix theory and linear algebra, emphasizing topics useful in other disciplines such as physics, economics and social sciences, natural sciences, and engineering",
        price: "Free",
        startDate: "2020/07/27",
        endDate: "2020/08/31",
        image: "placeholder.jpg",
        resources: "Learn Differential Equations: Up Close with Gilbert Strang and Cleve Moler",
        status: "Public",
        createdBy: "Sarah Jhinson"
      });
    }

    setLectures([
      { id: 1, name: "Lecture 1", order: 1 },
      { id: 2, name: "Lecture 2", order: 2 },
      // ... add more lectures up to 10
    ]);

    setAssignments([
      { userId: 1, fullName: "Dinh Quang Nguyen", email: "quangnd.hust1@gmail.com", lastAttempt: "2020-07-28 19:24:01", score: "0%", questionsAnswered: 4, isCompletedAnswered: "80%" },
      { userId: 2, fullName: "Hoang Nguyen", email: "hoangnguyen@gmail.com", lastAttempt: "2020-07-30 09:36:23", score: "20%", questionsAnswered: 3, isCompletedAnswered: "60%" },
      { userId: 3, fullName: "Hue Nguyen", email: "huenguyen@gmail.com", lastAttempt: "Not yet answered", score: "0%", questionsAnswered: 0, isCompletedAnswered: "0%" },
    ]);
  }, [id, course]);

  const handleAddLecture = () => {
    setOpenCreateDialog(true);
  };

  const handleCloseCreateDialog = () => {
    setOpenCreateDialog(false);
  };

  const handleSaveLecture = (newLecture) => {
    const newLectureWithId = { 
      ...newLecture, 
      id: lectures.length + 1, 
      order: lectures.length + 1 
    };
    setLectures([...lectures, newLectureWithId]);
    setOpenCreateDialog(false);
  };

  const handleEditCourse = () => {
    setOpenEditDialog(true);
  };

  const handleCloseEditDialog = () => {
    setOpenEditDialog(false);
  };

  const handleSaveEditedCourse = (editedCourse) => {
    setCourse(editedCourse);
    setOpenEditDialog(false);
    // Here you would typically send the updated course data to your backend
  };

 
  const handleLectureOperation = (lectureId, operation) => {
    switch (operation) {
      case 'view':
        const lectureToView = lectures.find(lecture => lecture.id === lectureId);
        setSelectedLecture(lectureToView);
        break;
      case 'delete':
        // ... existing delete logic ...
        break;
      default:
        console.log("Invalid operation");
    }
  };

  const handleConfirmDeleteLecture = () => {
    if (lectureToDelete) {
      setLectures(lectures.filter(lecture => lecture.id !== lectureToDelete.id));
      console.log("Đã xóa bài giảng");
      setOpenDeleteConfirmDialog(false);
      setLectureToDelete(null);
    }
  };

  const handleCancelDeleteLecture = () => {
    setOpenDeleteConfirmDialog(false);
    setLectureToDelete(null);
  };

  const handleViewLectureDetail = (lecture) => {
    setSelectedLecture(lecture);
    setOpenLectureDetailDialog(true);
  };

  const handleCloseLectureDetailDialog = () => {
    setOpenLectureDetailDialog(false);
    setSelectedLecture(null);
  };

  const handleEditLecture = (lecture) => {
    setSelectedLecture(lecture);
    setOpenLectureDetailDialog(false);
    setOpenCreateDialog(true);
  };

  const handleCreateExercise = () => {
    setOpenCreateExerciseDialog(true);
  };

  const handleCloseCreateExerciseDialog = () => {
    setOpenCreateExerciseDialog(false);
  };

  const handleSaveExercise = (newExercise) => {
    // Implement logic to save the new exercise
    console.log('New exercise:', newExercise);
    setOpenCreateExerciseDialog(false);
  };

  const handleCloseLectureDetail = () => {
    setSelectedLecture(null);
  };

  if (!course) {
    return <Typography>Loading...</Typography>;
  }

  if (selectedLecture) {
    return (
      <AdminLectureDetail
        lecture={selectedLecture}
        onClose={handleCloseLectureDetail}
      />
    );
  }

  return (
    <Container maxWidth="lg">
      <Box display="flex" justifyContent="space-between" alignItems="center" mb={2}>
        <Typography variant="h4">Course detail</Typography>
        <Box>
          <Button variant="contained" color="primary" onClick={handleAddLecture} style={{ marginRight: 10 }}>Add lecture</Button>
          <Button variant="contained" onClick={handleEditCourse}>Edit Course</Button>
        </Box>
      </Box>

      <Paper elevation={3} style={{ padding: 20, marginBottom: 20 }}>
        <Grid container spacing={2}>
          <Grid item xs={12} md={6}>
            <Typography><strong>Subject:</strong> {course.subject}</Typography>
            <Typography><strong>Course Code:</strong> {course.code}</Typography>
            <Typography><strong>Course Name:</strong> {course.name}</Typography>
            <Typography><strong>Description:</strong> {course.description}</Typography>
            <Typography><strong>Price:</strong> {course.price}</Typography>
            <Typography><strong>Start Date:</strong> {course.startDate}</Typography>
            <Typography><strong>End Date:</strong> {course.endDate}</Typography>
            <Typography><strong>Image:</strong> [Placeholder for image]</Typography>
            <Typography><strong>Resources:</strong> {course.resources}</Typography>
            <Typography><strong>Status:</strong> {course.status}</Typography>
            <Typography><strong>Created by:</strong> {course.createdBy}</Typography>
          </Grid>
          <Grid item xs={12} md={6}>
            <TableContainer>
              <Table>
                <TableHead>
                  <TableRow>
                    <TableCell>Lecture ID</TableCell>
                    <TableCell>Name</TableCell>
                    <TableCell>Order</TableCell>
                    <TableCell>Operation</TableCell>
                  </TableRow>
                </TableHead>
                <TableBody>
                  {lectures.map((lecture) => (
                    <TableRow key={lecture.id}>
                      <TableCell>{lecture.id}</TableCell>
                      <TableCell>{lecture.name}</TableCell>
                      <TableCell>{lecture.order}</TableCell>
                      <TableCell>
                        <StyledSelect
                          value=""
                          onChange={(e) => handleLectureOperation(lecture.id, e.target.value)}
                          displayEmpty
                        >
                          <MenuItem value="" disabled>Operation</MenuItem>
                          <MenuItem value="view">View Detail</MenuItem>
                          <MenuItem value="delete">Delete</MenuItem>
                        </StyledSelect>
                      </TableCell>
                    </TableRow>
                  ))}
                </TableBody>
              </Table>
            </TableContainer>
          </Grid>
        </Grid>
      </Paper>

      <Paper elevation={3} style={{ padding: 20 }}>
        <Typography variant="h6" gutterBottom>Quick Assignment Results Report</Typography>
        <TableContainer>
          <Table>
            <TableHead>
              <TableRow>
                <TableCell>User ID</TableCell>
                <TableCell>Full Name</TableCell>
                <TableCell>Email</TableCell>
                <TableCell>Last attempt</TableCell>
                <TableCell>Score</TableCell>
                <TableCell>Questions answered</TableCell>
                <TableCell>Is completed Answered?</TableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {assignments.map((assignment) => (
                <TableRow key={assignment.userId}>
                  <TableCell>{assignment.userId}</TableCell>
                  <TableCell>{assignment.fullName}</TableCell>
                  <TableCell>{assignment.email}</TableCell>
                  <TableCell>{assignment.lastAttempt}</TableCell>
                  <TableCell>{assignment.score}</TableCell>
                  <TableCell>{assignment.questionsAnswered}</TableCell>
                  <TableCell>{assignment.isCompletedAnswered}</TableCell>
                </TableRow>
              ))}
            </TableBody>
          </Table>
        </TableContainer>
        <Box display="flex" justifyContent="center" mt={2}>
          <Button>&lt;&lt;</Button>
          <Button>1</Button>
          <Button>2</Button>
          <Button>3</Button>
          <Button>...</Button>
          <Button>&gt;&gt;</Button>
        </Box>
      </Paper>

      <CreateandUpdateCourseDialog 
        open={openEditDialog} 
        onClose={handleCloseEditDialog} 
        onSave={handleSaveEditedCourse} 
        courseData={course}
        courses={[course]} 
        setCourses={(updatedCourses) => setCourse(updatedCourses[0])}
      />

      <CreateLectureDialog
        open={openCreateDialog}
        onClose={handleCloseCreateDialog}
        onSave={handleSaveLecture}
        lecture={selectedLecture}
      />

      {openLectureDetailDialog && (
        <LectureDetail
          open={openLectureDetailDialog}
          onClose={handleCloseLectureDetailDialog}
          lecture={selectedLecture}
          onEdit={handleEditLecture}
          onCreateExercise={handleCreateExercise}
        />
      )}

      <CreateandUpdateExerciseDialog
        open={openCreateExerciseDialog}
        onClose={handleCloseCreateExerciseDialog}
        onSave={handleSaveExercise}
      />

      <Dialog
        open={openDeleteConfirmDialog}
        onClose={handleCancelDeleteLecture}
        aria-labelledby="alert-dialog-title"
        aria-describedby="alert-dialog-description"
      >
        <DialogTitle id="alert-dialog-title">{"Xác nhận xóa bài giảng"}</DialogTitle>
        <DialogContent>
          <Typography>
            Bạn có chắc chắn muốn xóa bài giảng này?
          </Typography>
        </DialogContent>
        <DialogActions>
          <Button onClick={handleCancelDeleteLecture} color="primary">
            Hủy
          </Button>
          <Button onClick={handleConfirmDeleteLecture} color="primary" autoFocus>
            Xác nhận
          </Button>
        </DialogActions>
      </Dialog>
    </Container>
  );
};

export default AdminCourseDetail;