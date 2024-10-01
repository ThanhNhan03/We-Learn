import React, { useEffect } from 'react';
import { Drawer, Toolbar, List, ListItem, ListItemIcon, ListItemText } from '@mui/material';
import { Home, People, History, Article, QuestionAnswer, School, Book } from '@mui/icons-material'; // Import Book icon for Courses
import { Link, useLocation } from 'react-router-dom'; // Import Link from react-router-dom

const drawerWidth = 240;

const menuItems = [
  { text: 'Home', icon: <Home />, view: 'home', path: '/admin/dashboard' },
  { text: 'Users', icon: <People />, view: 'users', path: '/admin/dashboard/users' },
  { text: 'Courses', icon: <Book />, view: 'courses', path: '/admin/dashboard/courses' }, // Added Courses
  { text: 'Courses History', icon: <History />, view: 'coursesHistory', path: '/admin/dashboard/courses-history' },
  { text: 'News', icon: <Article />, view: 'news', path: '/admin/dashboard/news' },
  { text: 'Faqs', icon: <QuestionAnswer />, view: 'faqs', path: '/admin/dashboard/faqs' },
  { text: 'Educators', icon: <School />, view: 'educators', path: '/admin/dashboard/educators' },
];

const AdminDrawer = ({ darkMode, setView }) => {
  const location = useLocation();

  useEffect(() => {
    const currentPath = location.pathname;
    const currentItem = menuItems.find(item => item.path === currentPath);
    if (currentItem) {
      setView(currentItem.view);
    }
  }, [location, setView]);

  return (
    <Drawer
      variant="permanent"
      sx={{
        width: drawerWidth,
        flexShrink: 0,
        '& .MuiDrawer-paper': {
          width: drawerWidth,
          boxSizing: 'border-box',
          backgroundColor: darkMode ? '#424242' : '#fff',
        },
      }}
    >
      <Toolbar />
      <List>
        {menuItems.map((item) => (
          <ListItem 
            button 
            key={item.text} 
            component={Link} 
            to={item.path} 
            onClick={() => setView(item.view)} 
            sx={{
              '&:hover': {
                bgcolor: 'rgba(255, 0, 0, 0.2)', 
              }
            }}
          >
            <ListItemIcon sx={{ color: darkMode ? '#fff' : '#000' }}>{item.icon}</ListItemIcon>
            <ListItemText 
              primary={item.text} 
              sx={{ 
                color: 'purple', 
                '&:hover': {
                  color: 'rgba(255, 0, 0, 0.8)',
                }
              }} 
            />
          </ListItem>
        ))}
      </List>
    </Drawer>
  );
};

export default AdminDrawer;
