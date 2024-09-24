import React from 'react';
import {
  AppBar, Toolbar, Typography, Drawer, List, ListItem, ListItemIcon, ListItemText,
  Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper,
  IconButton, InputBase, Select, MenuItem, Button
} from '@mui/material';
import { Home, People, History, Article, QuestionAnswer, School, Search, MoreVert } from '@mui/icons-material';

const drawerWidth = 240;

const AdminDashboard = () => {
  const menuItems = [
    { text: 'Home', icon: <Home /> },
    { text: 'Users', icon: <People /> },
    { text: 'Courses History', icon: <History /> },
    { text: 'News', icon: <Article /> },
    { text: 'Faqs', icon: <QuestionAnswer /> },
    { text: 'Educators', icon: <School /> },
  ];

  const admins = [
    { lastName: 'Nguyen', email: 'quangnd.hust@gmail.com', birthday: '1996-04-15', phone: '0123456789', gender: 'Male', role: 'Teacher', status: true },
    { lastName: 'Hoang', email: 'dinhdinh@gmail.com', birthday: '1989-02-12', phone: '0567564978', gender: 'Female', role: 'Administrator', status: true },
    { lastName: 'Hoang', email: 'hoangnguyen@gmail.com', birthday: '1989-02-12', phone: '0977894149', gender: 'Female', role: 'Teacher', status: true },
  ];

  return (
    <div style={{ display: 'flex' }}>
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
        </Toolbar>
      </AppBar>
      <Drawer
        variant="permanent"
        sx={{
          width: drawerWidth,
          flexShrink: 0,
          [`& .MuiDrawer-paper`]: { width: drawerWidth, boxSizing: 'border-box' },
        }}
      >
        <Toolbar />
        <List>
          {menuItems.map((item, index) => (
            <ListItem button key={item.text}>
              <ListItemIcon>{item.icon}</ListItemIcon>
              <ListItemText primary={item.text} />
            </ListItem>
          ))}
        </List>
      </Drawer>
      <main style={{ flexGrow: 1, padding: '24px' }}>
        <Toolbar />
        <Typography variant="h6" sx={{ mb: 2 }}>Admin List</Typography>
        <Paper sx={{ mb: 2, display: 'flex', alignItems: 'center', justifyContent: 'space-between' }}>
          <InputBase sx={{ ml: 1, flex: 1 }} placeholder="Search" />
          <IconButton type="submit" sx={{ p: '10px' }} aria-label="search">
            <Search />
          </IconButton>
          <Button variant="contained" sx={{ m: 1 }}>Create admin</Button>
        </Paper>
        <TableContainer component={Paper}>
          <Table sx={{ minWidth: 650 }} aria-label="simple table">
            <TableHead>
              <TableRow>
                <TableCell>Last Name</TableCell>
                <TableCell>Email</TableCell>
                <TableCell>Birthday</TableCell>
                <TableCell>Phone</TableCell>
                <TableCell>Gender</TableCell>
                <TableCell>Role</TableCell>
                <TableCell>User Status</TableCell>
                <TableCell>Operation</TableCell>
              </TableRow>
            </TableHead>
            <TableBody>
              {admins.map((admin) => (
                <TableRow key={admin.email}>
                  <TableCell>{admin.lastName}</TableCell>
                  <TableCell>{admin.email}</TableCell>
                  <TableCell>{admin.birthday}</TableCell>
                  <TableCell>{admin.phone}</TableCell>
                  <TableCell>{admin.gender}</TableCell>
                  <TableCell>{admin.role}</TableCell>
                  <TableCell>{admin.status ? 'Active' : 'Inactive'}</TableCell>
                  <TableCell>
                    <IconButton>
                      <MoreVert />
                    </IconButton>
                  </TableCell>
                </TableRow>
              ))}
            </TableBody>
          </Table>
        </TableContainer>
      </main>
    </div>
  );
};

export default AdminDashboard;
