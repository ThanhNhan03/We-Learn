import React, { useState } from "react";
import { Box, Typography, TextField, Button, Grid, Avatar, Container, List, ListItem, ListItemText, Drawer, IconButton, FormControl, InputLabel, Select, MenuItem } from "@mui/material";
import { styled } from "@mui/system";
import { FiCamera, FiLock, FiCreditCard, FiPackage, FiMenu, FiUser } from "react-icons/fi";

const Sidebar = styled(Box)(({ theme }) => ({
  width: 250,
  backgroundColor: "#f5f5f5",
  padding: theme.spacing(2),
  [theme.breakpoints.down("md")]: {
    display: "none"
  }
}));

const MainContent = styled(Box)(({ theme }) => ({
  flexGrow: 1,
  padding: theme.spacing(3),
  backgroundColor: "#ffffff"
}));

const StyledAvatar = styled(Avatar)(({ theme }) => ({
  width: theme.spacing(15),
  height: theme.spacing(15),
  margin: "0 auto",
  marginBottom: theme.spacing(2),
  cursor: "pointer",
  transition: "transform 0.3s",
  "&:hover": {
    transform: "scale(1.1)"
  }
}));

const ErrorText = styled(Typography)(({ theme }) => ({
  color: theme.palette.error.main,
  fontSize: "0.75rem",
  marginTop: theme.spacing(0.5)
}));

const UserProfileSettings = () => {
  const [mobileOpen, setMobileOpen] = useState(false);
  const [firstName, setFirstName] = useState("Thomas");
  const [lastName, setLastName] = useState("Newman");
  const [birthday, setBirthday] = useState("1990-01-01");
  const [gender, setGender] = useState("male");
  const [errors, setErrors] = useState({});

  const handleDrawerToggle = () => {
    setMobileOpen(!mobileOpen);
  };

  const validateField = (name, value) => {
    if (!value) {
      setErrors((prev) => ({ ...prev, [name]: "Field cannot be empty" }));
    } else {
      setErrors((prev) => ({ ...prev, [name]: null }));
    }

    if (name === "birthday") {
      const dateRegex = /^\d{4}-\d{2}-\d{2}$/;
      if (!dateRegex.test(value)) {
        setErrors((prev) => ({ ...prev, [name]: "Invalid date format" }));
      }
    }
  };

  const handleChange = (event) => {
    const { name, value } = event.target;
    switch (name) {
      case "firstName":
        setFirstName(value);
        break;
      case "lastName":
        setLastName(value);
        break;
      case "birthday":
        setBirthday(value);
        break;
      case "gender":
        setGender(value);
        break;
      default:
        break;
    }
    validateField(name, value);
  };

  const sidebarContent = (
    <List>
      {["Your profile", "Account Security", "Subscriptions", "Payment Methods"].map((text, index) => (
        <ListItem button key={text} aria-label={text}>
          <IconButton>
            {index === 0 && <FiUser />}
            {index === 1 && <FiLock />}
            {index === 2 && <FiPackage />}
            {index === 3 && <FiCreditCard />}
          </IconButton>
          <ListItemText primary={text} />
        </ListItem>
      ))}
    </List>
  );

  return (
    <Container maxWidth="lg">
      <Box sx={{ display: "flex" }}>
        <IconButton
          color="inherit"
          aria-label="open drawer"
          edge="start"
          onClick={handleDrawerToggle}
          sx={{ mr: 2, display: { md: "none" } }}
        >
          <FiMenu />
        </IconButton>

        <Sidebar>
          {sidebarContent}
        </Sidebar>

        <Drawer
          variant="temporary"
          open={mobileOpen}
          onClose={handleDrawerToggle}
          ModalProps={{ keepMounted: true }}
          sx={{ display: { xs: "block", md: "none" } }}
        >
          {sidebarContent}
        </Drawer>

        <MainContent>
          <Typography variant="h4" gutterBottom sx={{ color: "grey.700", fontFamily: "sans-serif" }}>
            User Profile Settings
          </Typography>

          <StyledAvatar alt="Thomas Newman" src="images.unsplash.com/photo-1507003211169-0a1dd7228f2d?fit=crop&w=300&h=300">TN</StyledAvatar>

          <Grid container spacing={3}>
            <Grid item xs={12} sm={6}>
              <TextField
                fullWidth
                label="First Name"
                name="firstName"
                value={firstName}
                onChange={handleChange}
                error={!!errors.firstName}
                helperText={errors.firstName}
              />
            </Grid>
            <Grid item xs={12} sm={6}>
              <TextField
                fullWidth
                label="Last Name"
                name="lastName"
                value={lastName}
                onChange={handleChange}
                error={!!errors.lastName}
                helperText={errors.lastName}
              />
            </Grid>
            <Grid item xs={12} sm={6}>
              <TextField
                fullWidth
                label="Birthday"
                name="birthday"
                type="date"
                value={birthday}
                onChange={handleChange}
                error={!!errors.birthday}
                helperText={errors.birthday || "Format: YYYY-MM-DD"}
                InputLabelProps={{ shrink: true }}
              />
            </Grid>
            <Grid item xs={12} sm={6}>
              <FormControl fullWidth>
                <InputLabel id="gender-label">Gender</InputLabel>
                <Select
                  labelId="gender-label"
                  name="gender"
                  value={gender}
                  onChange={handleChange}
                  label="Gender"
                >
                  <MenuItem value="male">Male</MenuItem>
                  <MenuItem value="female">Female</MenuItem>
                  <MenuItem value="other">Other</MenuItem>
                </Select>
              </FormControl>
            </Grid>
          </Grid>

          <Box sx={{ mt: 4 }}>
            <Button variant="contained" color="primary">
              Save Changes
            </Button>
          </Box>
        </MainContent>
      </Box>
    </Container>
  );
};

export default UserProfileSettings;
