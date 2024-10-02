// CreateLectureDialog.jsx
import React, { useState, useEffect } from 'react';
import {
  Dialog, DialogTitle, DialogContent, DialogActions,
  TextField, Button, RadioGroup, Radio, FormControlLabel,
  Box, IconButton, Typography
} from '@mui/material';
import CloseIcon from '@mui/icons-material/Close';

const CreateLectureDialog = ({ open, onClose, onSave, lecture = null }) => {
  const [lectureData, setLectureData] = useState({
    id: '',
    name: '',
    description: '',
    type: 'video',
    file: null
  });

  useEffect(() => {
    if (lecture) {
      setLectureData(lecture);
    } else {
      setLectureData({
        id: '',
        name: '',
        description: '',
        type: 'video',
        file: null
      });
    }
  }, [lecture]);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setLectureData(prevState => ({
      ...prevState,
      [name]: value
    }));
  };

  const handleFileChange = (e) => {
    setLectureData(prevState => ({
      ...prevState,
      file: e.target.files[0]
    }));
  };

  const handleSubmit = () => {
    onSave(lectureData);
    onClose();
  };

  return (
    <Dialog open={open} onClose={onClose} maxWidth="md" fullWidth>
      <DialogTitle>
        {lecture ? 'Edit Lecture' : 'Create Lecture'}
        <IconButton
          aria-label="close"
          onClick={onClose}
          sx={{
            position: 'absolute',
            right: 8,
            top: 8,
            color: (theme) => theme.palette.grey[500],
          }}
        >
          <CloseIcon />
        </IconButton>
      </DialogTitle>
      <DialogContent>
        <Box component="form" sx={{ '& > :not(style)': { my: 2 } }}>
          <TextField
            fullWidth
            label="Name"
            name="name"
            value={lectureData.name}
            onChange={handleChange}
          />

          <TextField
            fullWidth
            label="Description"
            name="description"
            value={lectureData.description}
            onChange={handleChange}
            multiline
            rows={4}
          />

          <Typography variant="subtitle1" gutterBottom>
            Type:
          </Typography>
          <RadioGroup
            row
            name="type"
            value={lectureData.type}
            onChange={handleChange}
          >
            <FormControlLabel value="video" control={<Radio />} label="Video file" />
            <FormControlLabel value="document" control={<Radio />} label="Document file" />
          </RadioGroup>

          <Typography variant="subtitle1" gutterBottom>
            Video/Document file:
          </Typography>
          <Box sx={{ display: 'flex', alignItems: 'center', gap: 2 }}>
            <Button variant="contained" component="label">
              Choose File
              <input
                type="file"
                hidden
                onChange={handleFileChange}
              />
            </Button>
            <Typography variant="body2">
              {lectureData.file ? lectureData.file.name : 'No file chosen'}
            </Typography>
          </Box>

          {lectureData.file && (
            <Box sx={{ mt: 2, border: 1, borderColor: 'divider', p: 2 }}>
              <Typography variant="subtitle2" gutterBottom>
                Preview video or document file
              </Typography>
              {lectureData.type === 'video' ? (
                <video width="100%" controls>
                  <source src={URL.createObjectURL(lectureData.file)} type="video/mp4" />
                  Your browser does not support the video tag.
                </video>
              ) : (
                <iframe
                  src={URL.createObjectURL(lectureData.file)}
                  width="100%"
                  height="500px"
                  title="Document Preview"
                />
              )}
            </Box>
          )}
        </Box>
      </DialogContent>
      <DialogActions>
        <Button onClick={onClose}>Cancel</Button>
        <Button onClick={handleSubmit} variant="contained" color="primary">
          {lecture ? 'Save Changes' : 'Create'}
        </Button>
      </DialogActions>
    </Dialog>
  );
};

export default CreateLectureDialog;
