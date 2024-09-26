import React from 'react';
import { Dialog, DialogTitle, DialogContent, DialogActions, Button, Grid, TextField, FormControl, FormLabel, RadioGroup, FormControlLabel, Radio } from '@mui/material';

const CreateAccountDialog = ({ open, handleDialogClose, formData, handleChange, handleFileChange, handleSubmit }) => {
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
              name="phoneNumber"
              label="Telephone Number"
              fullWidth
              value={formData.phoneNumber}
              onChange={handleChange}
              margin="dense"
            />
          </Grid>
          <Grid item xs={12}>
            <FormControl fullWidth>
              <FormLabel>Image</FormLabel>
              <input
                type="file"
                name="image"
                onChange={handleFileChange}
                style={{ marginTop: '8px' }}
              />
            </FormControl>
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
                <FormControlLabel value="Female" control={<Radio />} label="Female" />
                <FormControlLabel value="Male" control={<Radio />} label="Male" />
                <FormControlLabel value="Other" control={<Radio />} label="Other" />
              </RadioGroup>
            </FormControl>
          </Grid>
        </Grid>
      </DialogContent>
      <DialogActions>
        <Button onClick={handleDialogClose}>Cancel</Button>
        <Button onClick={handleSubmit}>Submit</Button>
      </DialogActions>
    </Dialog>
  );
};

export default CreateAccountDialog;
