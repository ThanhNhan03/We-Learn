import React from "react";
import { IoMdMenu } from "react-icons/io";
import { motion } from "framer-motion";
import { AppBar, Toolbar, Typography, Button, IconButton, Menu, MenuItem, Box } from '@mui/material';

const NavbarMenu = [
  {
    id: 1,
    title: "Home",
    path: "/",
  },
  {
    id: 2,
    title: "Services",
    path: "#",
  },
  {
    id: 3,
    title: "About Us",
    path: "#",
  },
  {
    id: 4,
    title: "Our Team",
    path: "#",
  },
  {
    id: 5,
    title: "Contact Us",
    path: "#",
  },
];

const Navbar = () => {
  const [anchorEl, setAnchorEl] = React.useState(null);

  const handleMenuClick = (event) => {
    setAnchorEl(event.currentTarget);
  };

  const handleMenuClose = () => {
    setAnchorEl(null);
  };

  return (
    <AppBar position="static" sx={{ backgroundColor: 'white', color: 'black' }}>
      <motion.div
        initial={{ opacity: 0, y: -50 }}
        animate={{ opacity: 1, y: 0 }}
      >
        <Toolbar>
          {/* Logo section */}
          <Typography variant="h6" component="div" sx={{ flexGrow: 1 }}>
            The Coding Journey
          </Typography>
          {/* Menu section */}
          <Box sx={{ display: { xs: 'none', lg: 'flex' }, gap: 2 }}>
            {NavbarMenu.map((menu) => (
              <Button key={menu.id} href={menu.path} sx={{ color: 'black' }}>
                {menu.title}
              </Button>
            ))}
            <Button variant="contained" color="primary">Sign In</Button>
          </Box>
          {/* Mobile Hamburger menu section */}
          <Box sx={{ display: { xs: 'block', lg: 'none' } }}>
            <IconButton edge="start" color="inherit" aria-label="menu" onClick={handleMenuClick}>
              <IoMdMenu />
            </IconButton>
            <Menu
              anchorEl={anchorEl}
              open={Boolean(anchorEl)}
              onClose={handleMenuClose}
            >
              {NavbarMenu.map((menu) => (
                <MenuItem key={menu.id} onClick={handleMenuClose} component="a" href={menu.path}>
                  {menu.title}
                </MenuItem>
              ))}
              <MenuItem onClick={handleMenuClose}>
                <Button variant="contained" color="primary" fullWidth>Sign In</Button>
              </MenuItem>
            </Menu>
          </Box>
        </Toolbar>
      </motion.div>
    </AppBar>
  );
};

export default Navbar;
