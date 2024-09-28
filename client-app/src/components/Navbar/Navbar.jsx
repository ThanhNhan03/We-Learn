import React, { useState, useEffect } from "react";
import { IoMdMenu } from "react-icons/io";
import { motion } from "framer-motion";
import { AppBar, Toolbar, Typography, Button, IconButton, Menu, MenuItem, Box, InputBase, Avatar } from '@mui/material';
import { styled } from '@mui/system';
import { useNavigate } from "react-router-dom";

const NavbarMenu = [];

// Custom styled components
const Search = styled('div')(({ theme }) => ({
  position: 'relative',
  borderRadius: theme.shape.borderRadius,
  backgroundColor: '#f8f8f8',
  '&:hover': {
    backgroundColor: '#e8e8e8',
  },
  marginLeft: 0,
  width: '100%',
  [theme.breakpoints.up('sm')]: {
    marginLeft: theme.spacing(1),
    width: 'auto',
  },
}));

const SearchIconWrapper = styled('div')(({ theme }) => ({
  padding: theme.spacing(0, 2),
  height: '100%',
  position: 'absolute',
  pointerEvents: 'none',
  display: 'flex',
  alignItems: 'center',
  justifyContent: 'center',
}));

const StyledInputBase = styled(InputBase)(({ theme }) => ({
  color: 'inherit',
  '& .MuiInputBase-input': {
    padding: theme.spacing(1, 1, 1, 0),
    paddingLeft: `calc(1em + ${theme.spacing(4)})`,
    width: '100%',
  },
}));

const Navbar = () => {
  const [anchorEl, setAnchorEl] = React.useState(null);
  const [isLoggedIn, setIsLoggedIn] = useState(false);
  const [userRole, setUserRole] = useState(null); 
  const [userAnchorEl, setUserAnchorEl] = useState(null);
  const navigate = useNavigate(); 

  useEffect(() => {
    const accessToken = localStorage.getItem('accessToken');
    const role = localStorage.getItem('role');
    setIsLoggedIn(!!accessToken);
    setUserRole(role); 
  }, []);

  const handleMenuClick = (event) => {
    setAnchorEl(event.currentTarget);
  };

  const handleMenuClose = () => {
    setAnchorEl(null);
  };

  const handleUserMenuOpen = (event) => {
    setUserAnchorEl(event.currentTarget);
  };

  const handleUserMenuClose = () => {
    setUserAnchorEl(null);
  };

  const handleLogout = () => {
    localStorage.removeItem('accessToken');
    localStorage.removeItem('refreshToken');
    localStorage.removeItem('userRole'); 
    setIsLoggedIn(false);
    setUserRole(null); // Reset userRole
    navigate('/');
  };

  const handleNavigateHome = () => {
    navigate('/'); // Điều hướng về trang chủ
  };

  return (
    <AppBar position="static" sx={{ backgroundColor: 'white', color: 'black', boxShadow: 'none', borderBottom: '1px solid #e0e0e0' }}>
      <motion.div
        initial={{ opacity: 0, y: -50 }}
        animate={{ opacity: 1, y: 0 }}
      >
        <Toolbar sx={{ justifyContent: 'space-between' }}>
          {/* Logo section */}
          <Typography 
            variant="h6" 
            component="div" 
            sx={{ fontWeight: 'bold', color: '#5624d0', cursor: 'pointer' }} 
            style={{color: '#F76C6C'}}
            onClick={handleNavigateHome} // Thêm sự kiện onClick vào Typography
          >
            We Learn
          </Typography>
          
          {/* Search Bar */}
          <Search>
            <SearchIconWrapper>
              <svg
                xmlns="http://www.w3.org/2000/svg"
                fill="none"
                viewBox="0 0 24 24"
                stroke="currentColor"
                style={{ width: '20px', height: '20px', color: 'gray' }}
              >
                <path
                  strokeLinecap="round"
                  strokeLinejoin="round"
                  strokeWidth="2"
                  d="M21 21l-4.35-4.35M9 17a8 8 0 100-16 8 8 8 0 000 16z"
                />
              </svg>
            </SearchIconWrapper>
            <StyledInputBase
              placeholder="Search for anything"
              inputProps={{ 'aria-label': 'search' }}
            />
          </Search>

          {/* Menu section */}
          <Box sx={{ display: { xs: 'none', md: 'flex' }, gap: 2 }}>
            {NavbarMenu.map((menu) => (
              <Button key={menu.id} href={menu.path} sx={{ color: 'black', textTransform: 'none' }}>
                {menu.title}
              </Button>
            ))}
          </Box>

          <Box sx={{ display: 'flex', alignItems: 'center', gap: 1 }}>
            {isLoggedIn && userRole === 'User' ? ( 
              <>
                <Avatar
                  onClick={handleUserMenuOpen}
                  sx={{ cursor: 'pointer' }}
                >
                </Avatar>
                <Menu
                  anchorEl={userAnchorEl}
                  open={Boolean(userAnchorEl)}
                  onClose={handleUserMenuClose}
                >
                  <MenuItem onClick={() => { handleUserMenuClose(); navigate('/edit-profile'); }}>
                    Your Profile
                  </MenuItem>
                  <MenuItem onClick={() => { handleUserMenuClose(); handleLogout(); }}>
                    Logout
                  </MenuItem>
                </Menu>
              </>
            ) : (
              <>
                <Button onClick={() => navigate("/sign-in")} sx={{ textTransform: 'none' }}>Log-in</Button>
                <Button onClick={() => navigate("/sign-up")} variant="contained" color="primary" sx={{ textTransform: 'none' }}>
                  Sign-up
                </Button>
              </>
            )}
          </Box>

          {/* Mobile Hamburger menu section */}
          <Box sx={{ display: { xs: 'block', md: 'none' } }}>
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
                <Button onClick={() => navigate("/sign-in")} sx={{ textTransform: 'none' }}>Log-in</Button>
              </MenuItem>
              <MenuItem onClick={handleMenuClose}>
                <Button onClick={() => navigate("/sign-up")} variant="contained" color="primary" fullWidth>Sign-up</Button>
              </MenuItem>
            </Menu>
          </Box>
        </Toolbar>
      </motion.div>
    </AppBar>
  );
};

export default Navbar;