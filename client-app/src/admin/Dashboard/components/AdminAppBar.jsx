import React, { useContext } from 'react';
import { AppBar, Toolbar, Typography, Select, MenuItem, IconButton } from '@mui/material';
import { Brightness4, Brightness7 } from '@mui/icons-material';
import { useNavigate } from 'react-router-dom';
import { AdminContext } from '../../../contexts/AdminContext';

const AdminAppBar = ({ darkMode, handleThemeChange }) => {
  const navigate = useNavigate();
  const { admin, logout } = useContext(AdminContext);

  const handleMenuChange = (event) => {
    const selectedOption = event.target.value;
    if (selectedOption === 'Profile') {
      navigate('/admin/profile');
    } else if (selectedOption === 'Log Out') {
      logout();
      navigate('/login');
    }
  };

  const adminName = admin ? `${admin.firstname} ${admin.lastname}` : 'Admin';

  return (
    <AppBar position="fixed" sx={{ zIndex: (theme) => theme.zIndex.drawer + 1 }}>
      <Toolbar>
        <Typography variant="h6" noWrap component="div" sx={{ flexGrow: 1 }}>
          E-Learning
        </Typography>
        <Select value={adminName} onChange={handleMenuChange} sx={{ color: 'white' }}>
          <MenuItem value={adminName}>{adminName}</MenuItem>
          <MenuItem value="Profile">Profile</MenuItem>
          <MenuItem value="Log Out">Log Out</MenuItem>
        </Select>
        <IconButton sx={{ ml: 1 }} onClick={handleThemeChange} color="inherit">
          {darkMode ? <Brightness7 /> : <Brightness4 />}
        </IconButton>
      </Toolbar>
    </AppBar>
  );
};

export default AdminAppBar;