import  { useContext, useState } from 'react';
import { UserContext } from '../../contexts/UserContext';
import { IoMdMenu } from "react-icons/io";
import { motion } from "framer-motion";
import { AppBar, Toolbar, Typography, Button, IconButton, Menu, MenuItem, Box, InputBase, Avatar, Divider } from '@mui/material';
import { styled } from '@mui/system';
import { useNavigate } from "react-router-dom";
import SearchIcon from '@mui/icons-material/Search';
import { ThemeProvider, createTheme } from '@mui/material/styles';
import { Popover } from '@mui/material';
import logo from '../../assets/logo.png';
import ArrowDropDownIcon from '@mui/icons-material/ArrowDropDown';

// Create a theme instance
const theme = createTheme();

const NavbarMenu = [];

// Custom styled components
const Search = styled('div')(({ theme }) => ({
  position: 'relative',
  borderRadius: '50px', // Make it more rounded
  backgroundColor: '#F0F0F0', // Light gray background
  '&:hover': {
    backgroundColor: '#E0E0E0', // Slightly darker on hover
  },
  marginRight: theme.spacing(2),
  marginLeft: 0,
  width: '100%',
  [theme.breakpoints.up('sm')]: {
    marginLeft: theme.spacing(3),
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
  color: '#757575', // Gray color for the icon
}));

const StyledInputBase = styled(InputBase)(({ theme }) => ({
  color: 'inherit',
  '& .MuiInputBase-input': {
    padding: theme.spacing(1, 1, 1, 0),
    paddingLeft: `calc(1em + ${theme.spacing(4)})`,
    transition: theme.transitions.create('width'),
    width: '100%',
    [theme.breakpoints.up('md')]: {
      width: '100ch', // Increase width on larger screens
    },
  },
}));

const categories = [
  { id: 1, name: 'Technology', path: '/categories/technology' },
  { id: 2, name: 'Business', path: '/categories/business' },
  { id: 3, name: 'Science', path: '/categories/science' },
  { id: 4, name: 'Art', path: '/categories/art' },
];

const Navbar = () => {
  const { User, logout } = useContext(UserContext);
  const navigate = useNavigate();
  const [userAnchorEl, setUserAnchorEl] = useState(null);
  const [mobileAnchorEl, setMobileAnchorEl] = useState(null);
  const [categoryAnchorEl, setCategoryAnchorEl] = useState(null);
  const [categoryOpen, setCategoryOpen] = useState(false);
  const [isCategoryHovered, setIsCategoryHovered] = useState(false);
  const [learningPathAnchorEl, setLearningPathAnchorEl] = useState(null);
  const [isLearningPathHovered, setIsLearningPathHovered] = useState(false);

  const handleLogout = () => {
    logout();
    navigate('/');
  };

  const handleUserMenuOpen = (event) => {
    setUserAnchorEl(event.currentTarget);
  };

  const handleUserMenuClose = () => {
    setUserAnchorEl(null);
  };

  const handleMobileMenuOpen = (event) => {
    setMobileAnchorEl(event.currentTarget);
  };

  const handleMobileMenuClose = () => {
    setMobileAnchorEl(null);
  };

  const handleCategoryOpen = (event) => {
    setCategoryAnchorEl(event.currentTarget);
    setIsCategoryHovered(true);
  };

  const handleCategoryClose = () => {
    setCategoryAnchorEl(null);
    setIsCategoryHovered(false);
  };

  const handleNavigateHome = () => {
    navigate('/');
  };

  const handleLearningPathOpen = (event) => {
    setLearningPathAnchorEl(event.currentTarget);
    setIsLearningPathHovered(true);
  };

  const handleLearningPathClose = () => {
    setLearningPathAnchorEl(null);
    setIsLearningPathHovered(false);
  };

  return (
    <ThemeProvider theme={theme}>
      <AppBar position="fixed" sx={{ backgroundColor: 'white', color: 'black', boxShadow: 'none', borderBottom: '1px solid #e0e0e0', zIndex: (theme) => theme.zIndex.drawer + 1 }}>
        <motion.div
          initial={{ opacity: 0, y: -50 }}
          animate={{ opacity: 1, y: 0 }}
        >
         <Toolbar sx={{ justifyContent: 'space-between', display: 'flex', alignItems: 'center' }}>
  {/* Logo section with rounded image and text */}
  <Box sx={{ display: 'flex', alignItems: 'center', cursor: 'pointer' }} onClick={handleNavigateHome}>
<img 
  src={logo} 
  alt="logo" 
  style={{ 
width: 120, 
height: 80, 
    marginRight: 8,
borderRadius: '5%',  // This makes the image round
  // This ensures the image covers the area without distortion
  }} 
/>

</Box>
            

            {/* Categories Dropdown */}
            <Box
              onMouseEnter={handleCategoryOpen}
              onMouseLeave={handleCategoryClose}
              sx={{ marginLeft: 5 }}
            >
              <Button
              
                sx={{
                  color: isCategoryHovered ? 'deepblue' : 'inherit',
                  textTransform: 'none',
                  fontFamily: '"Poppins", sans-serif',
                  fontWeight: 700,  // Changed to bold (700)
                  fontSize: '1rem',
                  letterSpacing: '0.5px',
                  '&:hover': {
                    backgroundColor: 'transparent',
                  },
                }}
              >
                Categories
              </Button>
              <Menu
                anchorEl={categoryAnchorEl}
                open={Boolean(categoryAnchorEl)}
                onClose={handleCategoryClose}
                MenuListProps={{ onMouseLeave: handleCategoryClose }}
                anchorOrigin={{
                  vertical: 'bottom',
                  horizontal: 'left',
                }}
                transformOrigin={{
                  vertical: 'top',
                  horizontal: 'left',
                }}
              >
                {categories.map((category) => (
                  <MenuItem 
                    key={category.id} 
                    onClick={() => { 
                      handleCategoryClose(); 
                      navigate(category.path); 
                    }}
                  >
                    {category.name}
                  </MenuItem>
                ))}
              </Menu>
            </Box>

            {/* Centered Search Bar */}
            <Box sx={{ display: 'flex', justifyContent: 'center', flexGrow: 1 }}>
              <Search>
                <SearchIconWrapper>
                  <SearchIcon />
                </SearchIconWrapper>
                <StyledInputBase
                  placeholder="Search for anything"
                  inputProps={{ 'aria-label': 'search' }}
                />
              </Search>
            </Box>

            {/* My Learning Path Dropdown */}
            <Box
              onMouseEnter={handleLearningPathOpen}
              onMouseLeave={handleLearningPathClose}
              sx={{ marginLeft: 2, marginRight: 2 }}
            >
              <Button
               
                sx={{
                  color: isLearningPathHovered ? 'deepblue' : 'inherit',
                  textTransform: 'none',
                  fontFamily: '"Poppins", sans-serif',
                  fontWeight: 700,  // Changed to bold (700)
                  fontSize: '1rem',
                  letterSpacing: '0.5px',
                  '&:hover': {
                    backgroundColor: 'transparent',
                  },
                }}
              >
                My Learning Path
              </Button>
              <Menu
                anchorEl={learningPathAnchorEl}
                open={Boolean(learningPathAnchorEl)}
                onClose={handleLearningPathClose}
                MenuListProps={{ onMouseLeave: handleLearningPathClose }}
                anchorOrigin={{
                  vertical: 'bottom',
                  horizontal: 'left',
                }}
                transformOrigin={{
                  vertical: 'top',
                  horizontal: 'left',
                }}
              >
                <MenuItem onClick={handleLearningPathClose}>Path 1</MenuItem>
                <MenuItem onClick={handleLearningPathClose}>Path 2</MenuItem>
                <MenuItem onClick={handleLearningPathClose}>Path 3</MenuItem>
              </Menu>
            </Box>

            {/* User Actions */}
            <Box sx={{ display: 'flex', alignItems: 'center', gap: 1 }}>
              {User ? (
                <>
                  <Avatar onClick={handleUserMenuOpen} sx={{ cursor: 'pointer' }}>
                    {User.firstname[0]}
                  </Avatar>
                  <Menu
                    anchorEl={userAnchorEl}
                    open={Boolean(userAnchorEl)}
                    onClose={handleUserMenuClose}
                  >
                    <MenuItem onClick={() => { handleUserMenuClose(); navigate('/user/profile'); }}>
                      Your Profile
                    </MenuItem>
                    <MenuItem onClick={() => { handleUserMenuClose(); handleLogout(); }}>
                      Logout
                    </MenuItem>
                  </Menu>
                </>
              ) : (
                <>
                  <Button onClick={() => navigate("/sign-in")} sx={{ textTransform: 'none' }}>
                    Sign-in
                  </Button>
                  <Button onClick={() => navigate("/sign-up")} variant="contained" color="primary" sx={{ textTransform: 'none' }}>
                    Sign-up
                  </Button>
                </>
              )}
            </Box>

            {/* Mobile Hamburger menu section */}
            <Box sx={{ display: { xs: 'block', md: 'none' } }}>
              <IconButton edge="start" color="inherit" aria-label="menu" onClick={handleMobileMenuOpen}>
                <IoMdMenu />
              </IconButton>
              <Menu
                anchorEl={mobileAnchorEl}
                open={Boolean(mobileAnchorEl)}
                onClose={handleMobileMenuClose}
              >
                {NavbarMenu.map((menu) => (
                  <MenuItem key={menu.id} onClick={() => { handleMobileMenuClose(); navigate(menu.path); }}>
                    {menu.title}
                  </MenuItem>
                ))}
                <Divider />
                {User ? (
                  <MenuItem onClick={() => { handleMobileMenuClose(); handleLogout(); }}>
                    Logout
                  </MenuItem>
                ) : (
                  <>
                    <MenuItem key="sign-in" onClick={() => { handleMobileMenuClose(); navigate("/sign-in"); }}>
                      Sign-in
                    </MenuItem>
                    <MenuItem key="sign-up" onClick={() => { handleMobileMenuClose(); navigate("/sign-up"); }}>
                      Sign-up
                    </MenuItem>
                  </>
                )}
              </Menu>
            </Box>
          </Toolbar>
        </motion.div>
      </AppBar>
    </ThemeProvider>
  );
};

export default Navbar;