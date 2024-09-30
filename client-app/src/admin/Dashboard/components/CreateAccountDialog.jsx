import React from 'react';
import api from '../../../api/AxiosAPI';
import { Dialog, DialogTitle, DialogContent, DialogActions, Button, Grid, TextField, FormControl, FormLabel, RadioGroup, FormControlLabel, Radio } from '@mui/material';

const CreateAccountDialog = ({ open, handleDialogClose, formData, handleChange, handleFileChange, handleSubmit }) => {

  // Hàm handleSubmitForm thực hiện cuộc gọi API
  const handleSubmitForm = async () => {
    try {
      // Convert image to base64
      // const imageBase64 = await convertToBase64(formData.image);

      // Prepare data to send
      const dataToSend = {
        firstName: formData.firstName,
        lastName: formData.lastName,
        email: formData.email,
        birthday: formData.birthday,
        telephoneNumber: formData.telephoneNumber,
        password: formData.password,
        confirmPassword: formData.confirmPassword,
        role: formData.role,
        gender: formData.gender,
        // image: imageBase64
      };

      // Send data as JSON
      const response = await api.post('/Admin/add-admin', dataToSend, {
        headers: {
          'Content-Type': 'application/json'
        }
      });

      console.log('Admin created successfully:', response.data);
      handleDialogClose();
    } catch (error) {
      console.error('Error creating admin:', error);
      // Display error message to the user
      alert(error.message || "An error occurred while creating the account");
    }
  };

  // Helper function to convert File to base64
  const convertToBase64 = (file) => {
    return new Promise((resolve, reject) => {
      const reader = new FileReader();
      reader.readAsDataURL(file);
      reader.onload = () => resolve(reader.result);
      reader.onerror = (error) => reject(error);
    });
  };

  return (
    <Dialog open={open} onClose={handleDialogClose}>
      <DialogTitle>Create Account</DialogTitle>
      <DialogContent>
        <Grid container spacing={2}>
          <Grid item xs={6}>
            <TextField
              name="firstName"
              label="First Name"
              fullWidth
              value={formData.firstName}
              onChange={handleChange}
              margin="dense"
            />
          </Grid>
          <Grid item xs={6}>
            <TextField
              name="lastName"
              label="Last Name"
              fullWidth
              value={formData.lastName}
              onChange={handleChange}
              margin="dense"
            />
          </Grid>
          <Grid item xs={12}>
            <TextField
              name="email"
              label="Email"
              type="email"
              fullWidth
              value={formData.email}
              onChange={handleChange}
              margin="dense"
            />
          </Grid>
          <Grid item xs={6}>
            <TextField
              name="birthday"
              label="Birthday"
              type="date"
              fullWidth
              value={formData.birthday}
              onChange={handleChange}
              InputLabelProps={{ shrink: true }}
              margin="dense"
            />
          </Grid>
          <Grid item xs={6}>
            <TextField
              name="telephoneNumber" 
              label="Telephone Number"
              fullWidth
              value={formData.telephoneNumber}
              onChange={handleChange}
              margin="dense"
              required 
            />
          </Grid>
          {/* <Grid item xs={12}>
            <FormControl fullWidth>
              <FormLabel>Image</FormLabel>
              <input
                type="file"
                name="image"
                onChange={handleFileChange}
                style={{ marginTop: '8px' }}
              />
            </FormControl>
          </Grid> */}
          <Grid item xs={6}>
            <TextField
              name="password"
              label="Password"
              type="password"
              fullWidth
              value={formData.password}
              onChange={handleChange}
              margin="dense"
            />
          </Grid>
          <Grid item xs={6}>
            <TextField
              name="confirmPassword"
              label="Confirm Password"
              type="password"
              fullWidth
              value={formData.confirmPassword}
              onChange={handleChange}
              margin="dense"
            />
          </Grid>
          <Grid item xs={12}>
            <FormControl component="fieldset" fullWidth>
              <FormLabel component="legend">Role</FormLabel>
              <RadioGroup
                row
                name="role"
                value={formData.role}
                onChange={handleChange}
              >
                <FormControlLabel value="Admin" control={<Radio />} label="Admin" />
                <FormControlLabel value="Teacher" control={<Radio />} label="Teacher" />
              </RadioGroup>
            </FormControl>
          </Grid>
          <Grid item xs={12}>
            <FormControl component="fieldset" fullWidth>
              <FormLabel component="legend">Gender</FormLabel>
              <RadioGroup
                row
                name="gender"
                value={formData.gender}
                onChange={handleChange}
              >
                <FormControlLabel value="female" control={<Radio />} label="Female" />
                <FormControlLabel value="male" control={<Radio />} label="Male" />
                <FormControlLabel value="other" control={<Radio />} label="Other" />
              </RadioGroup>
            </FormControl>
          </Grid>
        </Grid>
      </DialogContent>
      <DialogActions>
        <Button onClick={handleDialogClose}>Cancel</Button>
        <Button onClick={handleSubmitForm}>Submit</Button> {/* Gọi hàm handleSubmitForm */}
      </DialogActions>
    </Dialog>
  );
};

export default CreateAccountDialog;
