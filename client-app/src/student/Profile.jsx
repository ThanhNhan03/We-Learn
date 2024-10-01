import React, { useState, useRef } from 'react';
import { Avatar, Typography, Grid, Paper, Button, Box, TextField, IconButton, Toolbar, Divider, MenuItem, CssBaseline } from '@mui/material';
import { Edit, Save, Person, Security } from '@mui/icons-material';
import { styled } from '@mui/material/styles';
import Navbar from '../components/Navbar/Navbar';


const StyledPaper = styled(Paper)(({ theme }) => ({
  padding: theme.spacing(4),
  marginTop: theme.spacing(4),
  borderRadius: theme.shape.borderRadius,
  backgroundColor: theme.palette.background.paper,
  boxShadow: theme.shadows[3],
  width: '100%',
  maxWidth: '900px',
  margin: 'auto',
}));

const SectionTitle = styled(Typography)(({ theme }) => ({
  marginBottom: theme.spacing(2),
  fontWeight: 500,
  color: theme.palette.text.primary,
}));

const Profile = () => {
  const [formData, setFormData] = useState({
    firstName: 'James',
    lastName: 'Johnson',
    email: 'jamesjohnson@arctic.com',
    phone: '+47 988 86 066',
    address: '123 Main St, Oslo, Norway',
    birthday: '1985-05-15',
    gender: 'Male',
    image: 'https://via.placeholder.com/150',
  });

  const [isEditing, setIsEditing] = useState(false);
  const [selectedPage, setSelectedPage] = useState('profile');
  const fileInputRef = useRef(null);
  const [passwordData, setPasswordData] = useState({
    currentPassword: '',
    newPassword: '',
    confirmNewPassword: '',
  });

  const handleEditToggle = () => {
    setIsEditing(!isEditing);
  };

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({
      ...formData,
      [name]: value,
    });
  };

  const handlePasswordChange = (e) => {
    const { name, value } = e.target;
    setPasswordData({
      ...passwordData,
      [name]: value,
    });
  };

  const handleImageChange = (e) => {
    const file = e.target.files[0];
    if (file) {
      const reader = new FileReader();
      reader.onloadend = () => {
        setFormData({
          ...formData,
          image: reader.result,
        });
      };
      reader.readAsDataURL(file);
    }
  };

  const triggerFileInput = () => {
    fileInputRef.current.click();
  };

  const handlePasswordSubmit = () => {
    if (passwordData.newPassword !== passwordData.confirmNewPassword) {
      alert("New passwords do not match!");
      return;
    }
    alert("Password changed successfully!");
  };

  return (
    <div style={{ display: 'flex', flexDirection: 'column' }}>
      <CssBaseline />

      <Navbar></Navbar>

      {/* Main content container */}
      <Box
        component="main"
        sx={{
          flexGrow: 1,
          p: 3,
          mt: { xs: 7, sm: 8 }, // Add margin to avoid overlap with the AppBar
          justifyContent: 'center',
        }}
      >
        <Toolbar /> {/* Adds spacing between the AppBar and content */}
        {selectedPage === 'profile' && (
          <StyledPaper>
            <Grid container spacing={3}>
              <Grid item xs={12} sm={4} container direction="column" alignItems="center">
                <Box sx={{ position: 'relative' }}>
                  <Avatar alt={formData.firstName} src={formData.image} sx={{ width: 150, height: 150 }} />
                  <IconButton sx={{ position: 'absolute', bottom: 0, right: 0 }} onClick={triggerFileInput}>
                    <Edit />
                  </IconButton>
                  <input type="file" accept="image/*" ref={fileInputRef} style={{ display: 'none' }} onChange={handleImageChange} />
                </Box>
                <Typography variant="h5" sx={{ mt: 2 }}>
                  {formData.firstName} {formData.lastName}
                </Typography>
                <Typography variant="subtitle1" color="textSecondary">
                  Administrator
                </Typography>
              </Grid>

              <Grid item xs={12} sm={8}>
                <SectionTitle variant="h6">Personal Information</SectionTitle>
                <Grid container spacing={2}>
                  <Grid item xs={12} sm={6}>
                    <TextField
                      fullWidth
                      label="First Name"
                      name="firstName"
                      value={formData.firstName}
                      onChange={handleChange}
                      variant="outlined"
                      InputProps={{ readOnly: !isEditing }}
                    />
                  </Grid>
                  <Grid item xs={12} sm={6}>
                    <TextField
                      fullWidth
                      label="Last Name"
                      name="lastName"
                      value={formData.lastName}
                      onChange={handleChange}
                      variant="outlined"
                      InputProps={{ readOnly: !isEditing }}
                    />
                  </Grid>
                  <Grid item xs={12} sm={6}>
                    <TextField
                      fullWidth
                      label="Birthday"
                      name="birthday"
                      type="date"
                      value={formData.birthday}
                      onChange={handleChange}
                      variant="outlined"
                      InputProps={{ readOnly: !isEditing }}
                      InputLabelProps={{ shrink: true }}
                    />
                  </Grid>
                  <Grid item xs={12} sm={6}>
                    <TextField
                      fullWidth
                      select
                      label="Gender"
                      name="gender"
                      value={formData.gender}
                      onChange={handleChange}
                      variant="outlined"
                      InputProps={{ readOnly: !isEditing }}
                    >
                      <MenuItem value="Male">Male</MenuItem>
                      <MenuItem value="Female">Female</MenuItem>
                      <MenuItem value="Other">Other</MenuItem>
                    </TextField>
                  </Grid>
                </Grid>
                <Divider sx={{ my: 3 }} />
                <SectionTitle variant="h6">Contact Information</SectionTitle>
                <Grid container spacing={2}>
                  <Grid item xs={12} sm={6}>
                    <TextField
                      fullWidth
                      label="Phone"
                      name="phone"
                      value={formData.phone}
                      onChange={handleChange}
                      variant="outlined"
                      InputProps={{ readOnly: !isEditing }}
                    />
                  </Grid>
                  <Grid item xs={12} sm={6}>
                    <TextField
                      fullWidth
                      label="Email"
                      name="email"
                      value={formData.email}
                      onChange={handleChange}
                      variant="outlined"
                      InputProps={{ readOnly: !isEditing }}
                    />
                  </Grid>
                  <Grid item xs={12}>
                    <TextField
                      fullWidth
                      label="Address"
                      name="address"
                      value={formData.address}
                      onChange={handleChange}
                      variant="outlined"
                      InputProps={{ readOnly: !isEditing }}
                    />
                  </Grid>
                </Grid>
              </Grid>
            </Grid>
            <Box sx={{ display: 'flex', justifyContent: 'flex-end', mt: 4 }}>
              <Button
                variant="contained"
                color={isEditing ? 'primary' : 'default'}
                startIcon={isEditing ? <Save /> : <Edit />}
                onClick={handleEditToggle}
              >
                {isEditing ? 'Save Changes' : 'Edit Profile'}
              </Button>
            </Box>
          </StyledPaper>
        )}

        {selectedPage === 'security' && (
          <StyledPaper>
            <SectionTitle variant="h6">Change Password</SectionTitle>
            <Grid container spacing={2}>
              <Grid item xs={12}>
                <TextField
                  fullWidth
                  label="Current Password"
                  type="password"
                  name="currentPassword"
                  value={passwordData.currentPassword}
                  onChange={handlePasswordChange}
                  variant="outlined"
                />
              </Grid>
              <Grid item xs={12}>
                <TextField
                  fullWidth
                  label="New Password"
                  type="password"
                  name="newPassword"
                  value={passwordData.newPassword}
                  onChange={handlePasswordChange}
                  variant="outlined"
                />
              </Grid>
              <Grid item xs={12}>
                <TextField
                  fullWidth
                  label="Confirm New Password"
                  type="password"
                  name="confirmNewPassword"
                  value={passwordData.confirmNewPassword}
                  onChange={handlePasswordChange}
                  variant="outlined"
                />
              </Grid>
            </Grid>

            <Box sx={{ display: 'flex', justifyContent: 'flex-end', mt: 4 }}>
              <Button variant="contained" color="primary" onClick={handlePasswordSubmit}>
                Change Password
              </Button>
            </Box>
          </StyledPaper>
        )}
      </Box>
    </div>
  );
};

export default Profile;