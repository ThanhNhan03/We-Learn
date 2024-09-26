import React, { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
// import axios from 'axios';
import {
  AppBar, Toolbar, Typography, Drawer, List, ListItem, ListItemIcon, ListItemText,
  Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper,
  IconButton, InputBase, Select, MenuItem, Button, Switch, Grid, Card, CardContent, Menu, Avatar
} from '@mui/material';
import { Home, People, History, Article, QuestionAnswer, School, Search, MoreVert, Brightness4, Brightness7 } from '@mui/icons-material';

const drawerWidth = 240;

const AdminDashboard = () => {
  const [darkMode, setDarkMode] = useState(false);
  const [view, setView] = useState('home');
  const [anchorEl, setAnchorEl] = useState(null);
  const [selectedUser, setSelectedUser] = useState(null);
  const [admins, setAdmins] = useState([]);
  const [users, setUsers] = useState([]);
  const navigate = useNavigate();

  // useEffect(() => {
  //   const fetchData = async () => {
  //     try {
  //       const adminsResponse = await axios.get('/api/admins');
  //       const usersResponse = await axios.get('/api/users');
  //       setAdmins(adminsResponse.data.length ? adminsResponse.data : [{}]);
  //       setUsers(usersResponse.data.length ? usersResponse.data : [{}]);
  //     } catch (error) {
  //       console.error('Error fetching data:', error);
  //       setAdmins([{}]);
  //       setUsers([{}]);
  //     }
  //   };

  //   fetchData();
  // }, []);

  const handleThemeChange = () => {
    setDarkMode(!darkMode);
  };

  const handleMenuOpen = (event, user) => {
    setAnchorEl(event.currentTarget);
    setSelectedUser(user);
  };

  const handleMenuClose = () => {
    setAnchorEl(null);
    setSelectedUser(null);
  };

  const menuItems = [
    { text: 'Home', icon: <Home />, view: 'home' },
    { text: 'Users', icon: <People />, view: 'users' },
    { text: 'Courses History', icon: <History />, view: 'courses' },
    { text: 'News', icon: <Article />, view: 'news' },
    { text: 'Faqs', icon: <QuestionAnswer />, view: 'faqs' },
    { text: 'Educators', icon: <School />, view: 'educators' },
  ];

  const renderHome = () => (
    <Grid container spacing={2}>
      <Grid item xs={6}>
        <Card onClick={() => setView('users')}>
          <CardContent>
            <Typography variant="h5">Users</Typography>
            <Typography variant="h6">{users.length}</Typography>
          </CardContent>
        </Card>
      </Grid>
      <Grid item xs={6}>
        <Card onClick={() => setView('educators')}>
          <CardContent>
            <Typography variant="h5">Educators</Typography>
            <Typography variant="h6">{admins.length}</Typography>
          </CardContent>
        </Card>
      </Grid>
      <Grid item xs={12} style={{ display: 'flex', justifyContent: 'flex-end' }}>
        <Button variant="contained" onClick={() => navigate('/admin/add')}>Create Account</Button>
      </Grid>
    </Grid>
  );

  const renderTable = (data) => (
    <TableContainer component={Paper} sx={{ backgroundColor: darkMode ? '#424242' : '#fff', color: darkMode ? '#fff' : '#000' }}>
      <Table sx={{ minWidth: 650 }} aria-label="simple table">
        <TableHead>
          <TableRow>
            <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Avatar</TableCell>
            <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Last Name</TableCell>
            <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Email</TableCell>
            <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Birthday</TableCell>
            <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Phone</TableCell>
            <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Gender</TableCell>
            <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Role</TableCell>
            <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>User Status</TableCell>
            <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Operation</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {data.map((item, index) => (
            <TableRow key={index}>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>
                {item.avatar && <Avatar src={item.avatar} />}
              </TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.lastName || ''}</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.email || ''}</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.birthday || ''}</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.phone || ''}</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.gender || ''}</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.role || ''}</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.status ? 'Active' : 'Inactive'}</TableCell>
              <TableCell>
                <IconButton onClick={(event) => handleMenuOpen(event, item)}>
                  <MoreVert sx={{ color: darkMode ? '#fff' : '#000' }} />
                </IconButton>
                <Menu
                  anchorEl={anchorEl}
                  open={Boolean(anchorEl)}
                  onClose={handleMenuClose}
                >
                  <MenuItem onClick={() => { /* Edit user functionality */ handleMenuClose(); }}>Edit Profile</MenuItem>
                  <MenuItem onClick={() => { /* View user details functionality */ handleMenuClose(); }}>View Details</MenuItem>
                  <MenuItem onClick={() => { /* Delete user functionality */ handleMenuClose(); }}>Delete User</MenuItem>
                </Menu>
              </TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </TableContainer>
  );

  return (
    <div style={{ display: 'flex', backgroundColor: darkMode ? '#333' : '#fff', color: darkMode ? '#fff' : '#000', minHeight: '100vh' }}>
      <AppBar position="fixed" sx={{ zIndex: (theme) => theme.zIndex.drawer + 1 }}>
        <Toolbar>
          <Typography variant="h6" noWrap component="div" sx={{ flexGrow: 1 }}>
            E-Learning
          </Typography>
          <Select value="Admin Name" sx={{ color: 'white' }}>
            <MenuItem value="Admin Name">Admin Name</MenuItem>
            <MenuItem value="Profile">Profile</MenuItem>
            <MenuItem value="Log Out">Log Out</MenuItem>
          </Select>
          <IconButton sx={{ ml: 1 }} onClick={handleThemeChange} color="inherit">
            {darkMode ? <Brightness7 /> : <Brightness4 />}
          </IconButton>
        </Toolbar>
      </AppBar>
      <Drawer
        variant="permanent"
        sx={{
          width: drawerWidth,
          flexShrink: 0,
          [`& .MuiDrawer-paper`]: { width: drawerWidth, boxSizing: 'border-box', backgroundColor: darkMode ? '#424242' : '#fff', color: darkMode ? '#fff' : '#000' },
        }}
      >
        <Toolbar />
        <List>
          {menuItems.map((item) => (
            <ListItem button key={item.text} onClick={() => setView(item.view)}>
              <ListItemIcon sx={{ color: darkMode ? '#fff' : '#000' }}>{item.icon}</ListItemIcon>
              <ListItemText primary={item.text} />
            </ListItem>
          ))}
        </List>
      </Drawer>
      <main style={{ flexGrow: 1, padding: '24px' }}>
        <Toolbar />
        {view === 'home' && renderHome()}
        {view === 'users' && (
          <>
            <Typography variant="h6" sx={{ mb: 2 }}>User List</Typography>
            <Paper sx={{ mb: 2, display: 'flex', alignItems: 'center', justifyContent: 'space-between', backgroundColor: darkMode ? '#424242' : '#fff', color: darkMode ? '#fff' : '#000' }}>
              <InputBase sx={{ ml: 1, flex: 1 }} placeholder="Search" />
              <IconButton type="submit" sx={{ p: '10px' }} aria-label="search">
                <Search />
              </IconButton>
            </Paper>
            {renderTable(users)}
          </>
        )}
        {view === 'educators' && (
          <>
            <Typography variant="h6" sx={{ mb: 2 }}>Educator List</Typography>
            <Paper sx={{ mb: 2, display: 'flex', alignItems: 'center', justifyContent: 'space-between', backgroundColor: darkMode ? '#424242' : '#fff', color: darkMode ? '#fff' : '#000' }}>
              <InputBase sx={{ ml: 1, flex: 1 }} placeholder="Search" />
              <IconButton type="submit" sx={{ p: '10px' }} aria-label="search">
                <Search />
              </IconButton>
            </Paper>
            {renderTable(admins)}
          </>
        )}
      </main>
    </div>
  );
};

export default AdminDashboard;
