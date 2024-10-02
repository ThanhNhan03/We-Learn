import React from 'react';
import { Dialog, DialogTitle, DialogContent, DialogActions, Button, Grid, TextField, InputAdornment, MenuItem, Select, FormControl, InputLabel } from '@mui/material';
import DateRangeIcon from '@mui/icons-material/DateRange';
import ImageIcon from '@mui/icons-material/Image';
import DescriptionIcon from '@mui/icons-material/Description';
import ArrowDropDownIcon from '@mui/icons-material/ArrowDropDown';
import { styled } from '@mui/material/styles';


const StyledDialog = styled(Dialog)(({ theme }) => ({
  '& .MuiDialogTitle-root': {
    backgroundColor: theme.palette.primary.main,
    color: theme.palette.primary.contrastText,
    padding: theme.spacing(2),
  },
  '& .MuiDialogContent-root': {
    padding: theme.spacing(3),
  },
  '& .MuiDialogActions-root': {
    padding: theme.spacing(2),
  },
}));

const StyledTextField = styled(TextField)(({ theme }) => ({
  '& .MuiOutlinedInput-root': {
    '&:hover fieldset': {
      borderColor: theme.palette.primary.main,
    },
    '&.Mui-focused fieldset': {
      borderColor: theme.palette.primary.main,
    },
  },
}));

const StyledSelect = styled(Select)(({ theme }) => ({
  '&:hover .MuiOutlinedInput-notchedOutline': {
    borderColor: theme.palette.primary.main,
  },
  '&.Mui-focused .MuiOutlinedInput-notchedOutline': {
    borderColor: theme.palette.primary.main,
  },
}));

const StyledFormControl = styled(FormControl)(({ theme }) => ({
  '& .MuiInputLabel-root': {
    transform: 'translate(14px, -9px) scale(0.75)',
    background: theme.palette.background.paper,
    padding: '0 4px',
  },
}));

const CourseDialog = ({ open, onClose, onSave, courseData, action, subjects }) => {
  const [formData, setFormData] = React.useState({ 
    subjectId: '', // Change 'subject' to 'subjectId'
    code: '', 
    name: '', 
    description: '', 
    price: '', 
    startDate: '', 
    endDate: '', 
    image: '', 
    resources: '', 
    status: '' 
  });

  React.useEffect(() => {
    if (courseData) {
      setFormData(courseData);
    }
  }, [courseData]);

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleImageChange = (e) => {
    const file = e.target.files[0];
    if (file) {
      const reader = new FileReader();
      reader.onloadend = () => {
        setFormData({ ...formData, image: reader.result });
      };
      reader.readAsDataURL(file);
    }
  };

  const handleSubmit = () => {
    const selectedSubject = subjects.find(subject => subject.id === formData.subjectId);
    const newCourse = { 
      ...formData, 
      id: Date.now(),
      subject: selectedSubject ? selectedSubject.name : '' // Add the subject name
    };
    onSave(newCourse);
    onClose();
  };

  return (
    <StyledDialog open={open} onClose={onClose} maxWidth="md" fullWidth>
      <DialogTitle>
        {action === 'add' ? 'Add Course' : 'Edit Course'}
      </DialogTitle>
      <DialogContent>
        <Grid container spacing={3}>
          <Grid item xs={12} sm={6}>
            <StyledFormControl fullWidth margin="normal">
              <InputLabel><strong>Subject</strong></InputLabel>
              <StyledSelect
                name="subjectId"
                value={formData.subjectId}
                onChange={handleChange}
                endAdornment={<ArrowDropDownIcon />}
              >
                {subjects.map((subject) => (
                  <MenuItem key={subject.id} value={subject.id}>{subject.name}</MenuItem>
                ))}
              </StyledSelect>
            </StyledFormControl>
          </Grid>
          <Grid item xs={12} sm={6}>
            <StyledTextField 
              name="code" 
              label={<strong>Course Code</strong>} 
              value={formData.code} 
              onChange={handleChange} 
              fullWidth 
              margin="normal"
            />
          </Grid>
          <Grid item xs={12}>
            <StyledTextField 
              name="name" 
              label={<strong>Course Name</strong>} 
              value={formData.name} 
              onChange={handleChange} 
              fullWidth 
              margin="normal"
            />
          </Grid>
          <Grid item xs={12}>
            <StyledTextField 
              name="description" 
              label={<strong>Description</strong>} 
              value={formData.description} 
              onChange={handleChange} 
              fullWidth 
              multiline 
              rows={4} 
              InputProps={{
                startAdornment: (
                  <InputAdornment position="start">
                    <DescriptionIcon />
                  </InputAdornment>
                ),
              }} 
              margin="normal"
            />
          </Grid>
          <Grid item xs={12} sm={4}>
            <StyledTextField 
              name="price" 
              label={<strong>Price</strong>} 
              value={formData.price} 
              onChange={handleChange} 
              fullWidth 
              margin="normal"
              type="number"
              InputProps={{
                startAdornment: <InputAdornment position="start">$</InputAdornment>,
              }}
            />
          </Grid>
          <Grid item xs={12} sm={4}>
            <StyledTextField 
              name="startDate" 
              label={<strong>Start Date</strong>} 
              value={formData.startDate} 
              onChange={handleChange} 
              fullWidth 
              type="date"
              InputProps={{
                startAdornment: (
                  <InputAdornment position="start">
                    <DateRangeIcon />
                  </InputAdornment>
                ),
              }} 
              margin="normal"
              InputLabelProps={{ shrink: true }}
            />
          </Grid>
          <Grid item xs={12} sm={4}>
            <StyledTextField 
              name="endDate" 
              label={<strong>End Date</strong>} 
              value={formData.endDate} 
              onChange={handleChange} 
              fullWidth 
              type="date"
              InputProps={{
                startAdornment: (
                  <InputAdornment position="start">
                    <DateRangeIcon />
                  </InputAdornment>
                ),
              }} 
              margin="normal"
              InputLabelProps={{ shrink: true }}
            />
          </Grid>
          <Grid item xs={12}>
            <input
              accept="image/*"
              style={{ display: 'none' }}
              id="image-upload"
              type="file"
              onChange={handleImageChange}
            />
            <label htmlFor="image-upload">
              <Button
                variant="outlined"
                component="span"
                startIcon={<ImageIcon />}
                fullWidth
              >
                Upload Image
              </Button>
            </label>
            {formData.image && (
              <img 
                src={formData.image} 
                alt="Course preview" 
                style={{ marginTop: '10px', maxWidth: '100%', maxHeight: '200px' }} 
              />
            )}
          </Grid>
          <Grid item xs={12}>
            <StyledTextField 
              name="resources" 
              label={<strong>Resources</strong>} 
              value={formData.resources} 
              onChange={handleChange} 
              fullWidth 
              multiline 
              rows={4} 
              margin="normal"
            />
          </Grid>
          <Grid item xs={12}>
            <StyledFormControl fullWidth margin="normal">
              <InputLabel><strong>Status</strong></InputLabel>
              <StyledSelect
                name="status"
                value={formData.status}
                onChange={handleChange}
              >
                <MenuItem value="public">Public</MenuItem>
                <MenuItem value="private">Private</MenuItem>
              </StyledSelect>
            </StyledFormControl>
          </Grid>
        </Grid>
      </DialogContent>
      <DialogActions>
        <Button onClick={onClose} color="secondary" variant="outlined">Cancel</Button>
        <Button onClick={handleSubmit} color="primary" variant="contained">
          {courseData ? 'Update' : 'Add'}
        </Button>
      </DialogActions>
    </StyledDialog>
  );
};

export default CourseDialog;
