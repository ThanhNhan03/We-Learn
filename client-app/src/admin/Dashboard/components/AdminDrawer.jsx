import React from 'react';
import { Drawer, Toolbar, List, ListItem, ListItemIcon, ListItemText } from '@mui/material';
import { Home, People, History, Article, QuestionAnswer, School } from '@mui/icons-material';
import { Link } from 'react-router-dom'; // Import Link from react-router-dom

const drawerWidth = 240;

const menuItems = [
  { text: 'Home', icon: <Home />, view: 'home', path: '/dashboard' },
  { text: 'Users', icon: <People />, view: 'users', path: '/admin/dashboard/users' },
  { text: 'Courses History', icon: <History />, view: 'courses', path: '/admin/dashboard/courses' },
  { text: 'News', icon: <Article />, view: 'news', path: '/admin/dashboard/news' },
  { text: 'Faqs', icon: <QuestionAnswer />, view: 'faqs', path: '/admin/dashboard/faqs' },
  { text: 'Educators', icon: <School />, view: 'educators', path: '/admin/dashboard/educators' },
];

const AdminDrawer = ({ darkMode, setView }) => {
  return (
    <Drawer
      variant="permanent"
      sx={{
        width: drawerWidth,
        flexShrink: 0,
        [`& .MuiDrawer-paper`]: {
          width: drawerWidth,
          boxSizing: 'border-box',
          backgroundColor: darkMode ? '#424242' : '#fff',
          color: darkMode ? '#fff' : '#000',
        },
      }}
    >
      <Toolbar />
      <List>
        {menuItems.map((item) => (
          <ListItem button key={item.text} component={Link} to={item.path} onClick={() => setView(item.view)}>
            <ListItemIcon sx={{ color: darkMode ? '#fff' : '#000' }}>{item.icon}</ListItemIcon>
            <ListItemText primary={item.text} />
          </ListItem>
        ))}
      </List>
    </Drawer>
  );
};

export default AdminDrawer;
