import React, { useState, useRef } from 'react';
import { Avatar, Typography, Grid, Paper, Button, Box, TextField, IconButton, Toolbar, Divider, MenuItem, Drawer, List, ListItem, ListItemIcon, ListItemText } from '@mui/material';
import { Edit, Save, Person, Security } from '@mui/icons-material';
import { styled } from '@mui/material/styles';
import AdminAppBar from './AdminAppBar';

const drawerWidth = 240; 

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

const AdminProfile = () => {
  const [formData, setFormData] = useState({
    firstName: 'James',
    lastName: 'Johnson',
    email: 'jamesjohnson@arctic.com',
    phone: '+47 988 86 066',
    address: '123 Main St, Oslo, Norway',
    birthday: '1985-05-15',
    gender: 'Male',
    image: 'https://via.placeholder.com/150', // Placeholder image
  });

  const [isEditing, setIsEditing] = useState(false);
  const [selectedPage, setSelectedPage] = useState('profile'); // To toggle between profile and security page
  const fileInputRef = useRef(null);

  // State for the Change Password form
  const [passwordData, setPasswordData] = useState({
    currentPassword: '',
    newPassword: '',
    confirmNewPassword: '',
  });

  const handleEditToggle = () => {
    setIsEditing(!isEditing);  // Toggle between Edit and Save mode
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
          image: reader.result,  // Set the image to the result of FileReader
        });
      };
      reader.readAsDataURL(file);  // Convert the file to base64 string
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
    // Proceed with submitting the password change
    alert("Password changed successfully!");
  };

  // Sidebar items
  const sidebarItems = [
    { text: 'My Profile', icon: <Person />, page: 'profile' },
    { text: 'Change Password', icon: <Security />, page: 'security' },
  ];

  return (
    <div style={{ display: 'flex' }}>
      {/* App Bar */}
      <AdminAppBar darkMode={false} handleThemeChange={() => {}} />

      {/* Sidebar Drawer */}
      <Drawer
        sx={{
          width: drawerWidth,
          flexShrink: 0,
          '& .MuiDrawer-paper': {
            width: drawerWidth,
            boxSizing: 'border-box',
          },
        }}
        variant="permanent"
        anchor="left"
      >
        <Toolbar />
        <List>
          {sidebarItems.map((item, index) => (
            <ListItem button key={index} onClick={() => setSelectedPage(item.page)}>
              <ListItemIcon>{item.icon}</ListItemIcon>
              <ListItemText primary={item.text} />
            </ListItem>
          ))}
        </List>
      </Drawer>

      {/* Main content container */}
      <Box
        component="main"
        sx={{
          flexGrow: 1,
          p: 3,
          
         
          justifyContent: 'center',
        }} // Ensure it's centered
      >
        <Toolbar /> {/* Adds spacing between the AppBar and content */}

        {/* Conditionally render pages based on sidebar selection */}
        {selectedPage === 'profile' && (
          <StyledPaper>
            <Grid container spacing={3}>
              {/* Avatar and Name Section */}
              <Grid item xs={12} sm={4} container direction="column" alignItems="center">
                <Box sx={{ position: 'relative' }}>
                  <Avatar
                    alt={formData.firstName}
                    src={formData.image}
                    sx={{ width: 150, height: 150 }}
                  />
                  <IconButton
                    sx={{ position: 'absolute', bottom: 0, right: 0 }}
                    onClick={triggerFileInput}  // Trigger file input on click
                  >
                    <Edit />
                  </IconButton>
                  <input
                    type="file"
                    accept="image/*"
                    ref={fileInputRef}
                    style={{ display: 'none' }}  // Hidden file input
                    onChange={handleImageChange}
                  />
                </Box>
                <Typography variant="h5" sx={{ mt: 2 }}>
                  {formData.firstName} {formData.lastName}
                </Typography>
                <Typography variant="subtitle1" color="textSecondary">
                  Administrator
                </Typography>
              </Grid>

              {/* Profile Info Section */}
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
                      InputProps={{
                        readOnly: !isEditing,  // Disable input if not in editing mode
                      }}
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
                      InputProps={{
                        readOnly: !isEditing,
                      }}
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
                      InputProps={{
                        readOnly: !isEditing,
                      }}
                      InputLabelProps={{
                        shrink: true,  // Keeps the label above the date field
                      }}
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
                      InputProps={{
                        readOnly: !isEditing,
                      }}
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
                      InputProps={{
                        readOnly: !isEditing,
                      }}
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
                      InputProps={{
                        readOnly: !isEditing,
                      }}
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
                      InputProps={{
                        readOnly: !isEditing,
                      }}
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

        {/* Manage Security Page */}
        {selectedPage === 'security' && (
          <StyledPaper>
            <SectionTitle variant="h6">Change Password</SectionTitle>
            
            {/* Change Password Form */}
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
              <Button
                variant="contained"
                color="primary"
                onClick={handlePasswordSubmit}
              >
                Change Password
              </Button>
            </Box>
          </StyledPaper>
        )}
      </Box>
    </div>
  );
};

export default AdminProfile;