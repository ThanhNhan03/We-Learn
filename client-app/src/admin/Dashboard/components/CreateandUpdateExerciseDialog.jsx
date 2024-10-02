import React, { useState } from 'react';
import {
  Dialog,
  DialogTitle,
  DialogContent,
  DialogActions,
  Button,
  TextField,
} from '@mui/material';

const CreateExerciseDialog = ({ open, onClose, onSave }) => {
  const [exerciseName, setExerciseName] = useState('');

  const handleSubmit = () => {
    onSave({ name: exerciseName });
    setExerciseName('');
  };

  return (
    <Dialog open={open} onClose={onClose}>
      <DialogTitle>Create Exercise</DialogTitle>
      <DialogContent>
        <TextField
          autoFocus
          margin="dense"
          label="Exercise Name"
          type="text"
          fullWidth
          value={exerciseName}
          onChange={(e) => setExerciseName(e.target.value)}
        />
      </DialogContent>
      <DialogActions>
        <Button onClick={onClose}>Cancel</Button>
        <Button onClick={handleSubmit}>Create</Button>
      </DialogActions>
    </Dialog>
  );
};

export default CreateExerciseDialog;