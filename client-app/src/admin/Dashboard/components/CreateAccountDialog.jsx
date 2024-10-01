import React, { useState } from 'react';
import api from '../../../api/AxiosAPI';
import { Dialog, DialogTitle, DialogContent, DialogActions, Button, Grid, TextField, FormControl, FormLabel, RadioGroup, FormControlLabel, Radio } from '@mui/material';
import { toast, ToastContainer } from 'react-toastify'; // Import Toastify
// import 'react-toastify/dist/ReactToastify.css'; 

const CreateAccountDialog = ({ open, handleDialogClose, formData, handleChange, handleFileChange, handleSubmit }) => {
  const [phoneError, setPhoneError] = useState('');

  const handleSubmitForm = async () => {
    if (!validateVietnamesePhone(formData.telephoneNumber)) {
      setPhoneError('Please enter a valid phone number');
      return;
    }
    try {
      // const imageBase64 = await convertToBase64(formData.image);

    
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

      // Show success toast based on role
      if (formData.role === 'Admin') {
        toast.success('Admin created successfully!');
      } else if (formData.role === 'Teacher') {
        toast.success('Teacher created successfully!');
      }

      handleDialogClose();
    } catch (error) {
      console.error('Error creating account:', error);
      toast.error(error.message || "An error occurred while creating the account");
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

  // Function to validate Vietnamese phone numbers
  const validateVietnamesePhone = (phone) => {
    const phoneRegex = /^(0|\+84)(\s?)(3[2-9]|5[6|8|9]|7[0|6-9]|8[0-6|8|9]|9[0-4|6-9])(\d)(\s?\d{3})(\s?\d{3})$/;
    return phoneRegex.test(phone);
  };

  // Function to handle phone number changes
  const handlePhoneChange = (event) => {
    const { name, value } = event.target;
    handleChange(event);
    if (!validateVietnamesePhone(value)) {
      setPhoneError('Invalid phone number');
    } else {
      setPhoneError('');
    }
  };

  return (
    <>
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
                label="Phone Number"
                fullWidth
                value={formData.telephoneNumber}
                onChange={handlePhoneChange}
                margin="dense"
                required 
                error={!!phoneError}
                helperText={phoneError}
              />
            </Grid>
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
          <Button onClick={handleSubmitForm}>Submit</Button>
        </DialogActions>
      </Dialog>
      <ToastContainer /> {/* Thêm container của Toastify */}
    </>
  );
};

export default CreateAccountDialog;
