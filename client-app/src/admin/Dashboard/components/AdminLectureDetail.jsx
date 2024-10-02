import React, { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';
import {
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
  Container,
} from '@mui/material';
import { styled } from '@mui/material/styles';
import CreateandUpdateLectureDialog from './CreateandUpdateLectureDialog';
import CreateandUpdateExerciseDialog from './CreateandUpdateExerciseDialog';

const StyledSelect = styled(Select)(({ theme }) => ({
  '&:hover .MuiOutlinedInput-notchedOutline': {
    borderColor: theme.palette.primary.main,
  },
  '&.Mui-focused .MuiOutlinedInput-notchedOutline': {
    borderColor: theme.palette.primary.main,
  },
}));

const AdminLectureDetail = ({ lecture: initialLecture, onClose }) => {
  const { id } = useParams();
  const [lecture, setLecture] = useState(initialLecture || null);
  const [exercises, setExercises] = useState([]);
  const [openEditDialog, setOpenEditDialog] = useState(false);
  const [openCreateExerciseDialog, setOpenCreateExerciseDialog] = useState(false);
  const [selectedExercise, setSelectedExercise] = useState(null);
  const [openDeleteConfirmDialog, setOpenDeleteConfirmDialog] = useState(false);
  const [exerciseToDelete, setExerciseToDelete] = useState(null);

  useEffect(() => {
    if (!lecture) {
      // Fetch lecture details if not provided as prop
      // For now, we'll use mock data
      setLecture({
        id: parseInt(id),
        name: "Introduction to Linear Algebra",
        description: "This lecture covers the basics of linear algebra, including vectors and matrices.",
        type: "video",
        file: null,
        createdBy: "Prof. John Doe"
      });
    }

    setExercises([
      { id: 1, name: "Exercise 1", type: "Multiple Choice" },
      { id: 2, name: "Exercise 2", type: "Short Answer" },
      // ... add more exercises
    ]);
  }, [id, lecture]);

  const handleEditLecture = () => {
    setOpenEditDialog(true);
  };

  const handleCloseEditDialog = () => {
    setOpenEditDialog(false);
  };

  const handleSaveEditedLecture = (editedLecture) => {
    setLecture(editedLecture);
    setOpenEditDialog(false);
    // Here you would typically send the updated lecture data to your backend
  };

  const handleAddExercise = () => {
    setSelectedExercise(null);
    setOpenCreateExerciseDialog(true);
  };

  const handleCloseCreateExerciseDialog = () => {
    setOpenCreateExerciseDialog(false);
  };

  const handleSaveExercise = (newExercise) => {
    setExercises([...exercises, { ...newExercise, id: exercises.length + 1 }]);
    setOpenCreateExerciseDialog(false);
  };

  const handleExerciseOperation = (exerciseId, operation) => {
    switch (operation) {
      case 'edit':
        const exerciseToEdit = exercises.find(exercise => exercise.id === exerciseId);
        if (exerciseToEdit) {
          setSelectedExercise(exerciseToEdit);
          setOpenCreateExerciseDialog(true);
        }
        break;
      case 'delete':
        setExerciseToDelete(exercises.find(exercise => exercise.id === exerciseId));
        setOpenDeleteConfirmDialog(true);
        break;
      default:
        console.log("Invalid operation");
    }
  };

  const handleConfirmDeleteExercise = () => {
    if (exerciseToDelete) {
      setExercises(exercises.filter(exercise => exercise.id !== exerciseToDelete.id));
      setOpenDeleteConfirmDialog(false);
      setExerciseToDelete(null);
    }
  };

  const handleCancelDeleteExercise = () => {
    setOpenDeleteConfirmDialog(false);
    setExerciseToDelete(null);
  };

  if (!lecture) {
    return <Typography>Loading...</Typography>;
  }

  return (
    <Container maxWidth="lg">
      <Box display="flex" justifyContent="space-between" alignItems="center" mb={2}>
        <Typography variant="h4">Lecture Detail</Typography>
        <Box>
          <Button variant="contained" color="primary" onClick={handleAddExercise} style={{ marginRight: 10 }}>
            Add Exercise
          </Button>
          <Button variant="contained" onClick={handleEditLecture} style={{ marginRight: 10 }}>
            Edit Lecture
          </Button>
          <Button variant="outlined" onClick={onClose}>
            Back to Course Detail
          </Button>
        </Box>
      </Box>

      <Paper elevation={3} style={{ padding: 20, marginBottom: 20 }}>
        <Grid container spacing={4}>
          <Grid item xs={12} md={6}>
            <Typography variant="h6" gutterBottom><strong>Lecture Information</strong></Typography>
            <Typography><strong>Lecture Name:</strong> {lecture.name}</Typography>
            <Typography><strong>Description:</strong> {lecture.description}</Typography>
            <Typography><strong>Type:</strong> {lecture.type === 'video' ? 'Video file' : 'Document file'}</Typography>
            <Typography><strong>Created by:</strong> {lecture.createdBy}</Typography>
          </Grid>
          <Grid item xs={12} md={6}>
            <Typography variant="h6" gutterBottom><strong>Content:</strong></Typography>
            {lecture.file && (
              lecture.type === 'video' ? (
                <video width="100%" controls>
                  <source src={URL.createObjectURL(lecture.file)} type="video/mp4" />
                  Your browser does not support the video tag.
                </video>
              ) : (
                <iframe
                  src={URL.createObjectURL(lecture.file)}
                  width="100%"
                  height="500px"
                  title="Document Preview"
                />
              )
            )}
          </Grid>
        </Grid>
      </Paper>

      <Paper elevation={3} style={{ padding: 20 }}>
        <Typography variant="h6" gutterBottom><strong>Exercises</strong></Typography>
        <TableContainer>
          <Table>
            <TableHead>
              <TableRow>
                <TableCell>ID</TableCell>
                <TableCell>Name</TableCell>
                <TableCell>Type</TableCell>
                <TableCell>Operation</TableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {exercises.map((exercise) => (
                <TableRow key={exercise.id}>
                  <TableCell>{exercise.id}</TableCell>
                  <TableCell>{exercise.name}</TableCell>
                  <TableCell>{exercise.type}</TableCell>
                  <TableCell>
                    <StyledSelect
                      value=""
                      onChange={(e) => handleExerciseOperation(exercise.id, e.target.value)}
                      displayEmpty
                    >
                      <MenuItem value="" disabled>Operation</MenuItem>
                      <MenuItem value="edit">Edit</MenuItem>
                      <MenuItem value="delete">Delete</MenuItem>
                    </StyledSelect>
                  </TableCell>
                </TableRow>
              ))}
            </TableBody>
          </Table>
        </TableContainer>
      </Paper>

      <CreateandUpdateLectureDialog 
        open={openEditDialog} 
        onClose={handleCloseEditDialog} 
        onSave={handleSaveEditedLecture} 
        lecture={lecture}
      />

      <CreateandUpdateExerciseDialog
        open={openCreateExerciseDialog}
        onClose={handleCloseCreateExerciseDialog}
        onSave={handleSaveExercise}
        exercise={selectedExercise}
      />

      <Dialog
        open={openDeleteConfirmDialog}
        onClose={handleCancelDeleteExercise}
        aria-labelledby="alert-dialog-title"
        aria-describedby="alert-dialog-description"
      >
        <DialogTitle id="alert-dialog-title">{"Confirm Delete Exercise"}</DialogTitle>
        <DialogContent>
          <Typography>
            Are you sure you want to delete this exercise?
          </Typography>
        </DialogContent>
        <DialogActions>
          <Button onClick={handleCancelDeleteExercise} color="primary">
            Cancel
          </Button>
          <Button onClick={handleConfirmDeleteExercise} color="primary" autoFocus>
            Confirm
          </Button>
        </DialogActions>
      </Dialog>
    </Container>
  );
};

export default AdminLectureDetail;