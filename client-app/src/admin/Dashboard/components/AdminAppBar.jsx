import React, { useContext } from 'react';
import { AppBar, Toolbar, Typography, Select, MenuItem, IconButton } from '@mui/material';
import { Brightness4, Brightness7 } from '@mui/icons-material';
import { AdminContext } from '../../../contexts/AdminContext';

const AdminAppBar = ({ darkMode, handleThemeChange }) => {
  const { admin, logout } = useContext(AdminContext);

  const handleLogout = () => {
    logout();
    window.location.href = '/sign-in';
  };

  const displayName = admin ? `${admin.firstname || ''} ${admin.lastame || ''}`.trim() : 'No login';

  return (
    <AppBar position="fixed" sx={{ zIndex: (theme) => theme.zIndex.drawer + 1 }}>
      <Toolbar>
        <Typography variant="h6" noWrap component="div" sx={{ flexGrow: 1 }}>
          E-Learning
        </Typography>
        <Select
          value={displayName}
          sx={{ color: 'white' }}
        >
          <MenuItem value={displayName}>{displayName}</MenuItem>
          <MenuItem value="Profile">Profile</MenuItem>
          <MenuItem value="Log Out" onClick={handleLogout}>Logout</MenuItem>
        </Select>
        <IconButton sx={{ ml: 1 }} onClick={handleThemeChange} color="inherit">
          {darkMode ? <Brightness7 /> : <Brightness4 />}
        </IconButton>
      </Toolbar>
    </AppBar>
  );
};

export default AdminAppBar;
