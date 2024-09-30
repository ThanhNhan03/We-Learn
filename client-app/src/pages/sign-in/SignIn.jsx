import React, { useState, useContext } from "react";
import { useNavigate } from "react-router-dom";
import { Box, Button, TextField, Typography, FormControl, FormLabel, FormControlLabel, Checkbox, Link, Divider, Stack, Card as MuiCard, IconButton } from "@mui/material";
import ArrowBackIcon from '@mui/icons-material/ArrowBack';
import { styled } from "@mui/material/styles";
import { AdminContext } from '../../contexts/AdminContext';
import { UserContext } from '../../contexts/UserContext';
import ForgotPassword from "./ForgotPassword";
import { GoogleIcon, FacebookIcon } from "./CustomIcons";
import { toast, ToastContainer } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import LoadingOverlay from "../../common/LoadingOverlay";
import api from "../../api/AxiosAPI";
import { Visibility, VisibilityOff } from '@mui/icons-material';
import InputAdornment from '@mui/material/InputAdornment';

// Styled Components
const Card = styled(MuiCard)(({ theme }) => ({
  display: "flex",
  flexDirection: "column",
  alignSelf: "center",
  width: "100%",
  padding: theme.spacing(4),
  gap: theme.spacing(2),
  margin: "auto",
  fontFamily: "Arial, sans-serif",
  [theme.breakpoints.up("sm")]: {
    maxWidth: "450px",
  },
  boxShadow: "hsla(220, 30%, 5%, 0.05) 0px 5px 15px 0px, hsla(220, 25%, 10%, 0.05) 0px 15px 35px -5px",
}));

const SignInContainer = styled(Stack)(({ theme }) => ({
  padding: 20,
  marginTop: "10vh",
  fontFamily: "Arial, sans-serif",
}));

export default function SignIn() {
  const [formData, setFormData] = useState({
    email: "",
    password: "",
  });
  const [errors, setErrors] = useState({});
  const [loading, setLoading] = useState(false);
  const [open, setOpen] = useState(false);
  const navigate = useNavigate();
  const { login: loginAdmin } = useContext(AdminContext);
  const { login: loginUser } = useContext(UserContext);
  const [showPassword, setShowPassword] = useState(false);

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setFormData((prev) => ({ ...prev, [name]: value }));
    setErrors((prev) => ({ ...prev, [name]: "" }));
  };

  const validateInputs = () => {
    const newErrors = {};
    if (!formData.email || !/\S+@\S+\.\S+/.test(formData.email)) {
      newErrors.email = "Please enter a valid email address.";
    }
    if (!formData.password || formData.password.length < 6) {
      newErrors.password = "Password must be at least 6 characters long.";
    }
    setErrors(newErrors);
    return Object.keys(newErrors).length === 0;
  };

  const handleSubmit = async (event) => {
    event.preventDefault();
    if (!validateInputs()) return;

    setLoading(true);

    try {
      const response = await api.post("/Auth/login", formData);
      const { accessToken, refreshToken, role, userInfo, adminInfo } = response.data;
      
      console.log(response.data);
      if (accessToken && refreshToken !== undefined) {
        localStorage.setItem("accessToken", accessToken);
        localStorage.setItem("refreshToken", refreshToken || "");
        localStorage.setItem("role", role);

        const info = role === "Admin" ? adminInfo : userInfo;
        const userData = {
          id: info?.id || "",
          firstname: info?.firstName || "",
          lastname: info?.lastName || "",
          email: info?.email || formData.email,
          role: role,
        };

        if (role === "Admin" || role === "Teacher") {
          loginAdmin(userData);
          navigate("/admin/dashboard");
        } else {
          loginUser(userData);
          navigate("/");
        }

        toast.success("Login successful!");
      } else {
        throw new Error("Login response missing tokens");
      }
    } catch (error) {
      console.error("Login error:", error);
      toast.error(error.response?.data || error.message || "Login failed, please try again.");
    } finally {
      setLoading(false);
    }
  };

  // Kiểm soát khi nhấn Enter trên form
  const handleKeyPress = (e) => {
    if (e.key === 'Enter') {
      e.preventDefault();
      handleSubmit(e);
    }
  };

  const handleClickShowPassword = () => {
    setShowPassword(!showPassword);
  };

  const handleMouseDownPassword = (event) => {
    event.preventDefault();
  };

  return (
    <SignInContainer direction="column" justifyContent="space-between">
      <IconButton
        aria-label="back to home"
        onClick={() => navigate('/')}
        sx={{
          position: 'absolute',
          top: 20,
          left: 20,
          color: 'primary.main',
        }}
      >
        <ArrowBackIcon />
      </IconButton>
      <ToastContainer />
      <LoadingOverlay open={loading} />
      <Card variant="outlined">
        <Typography component="h1" variant="h4" sx={{ width: "100%", fontSize: "clamp(2rem, 10vw, 2.15rem)" }}>
          Login
        </Typography>
        <Box component="form" onSubmit={handleSubmit} noValidate sx={{ display: "flex", flexDirection: "column", width: "100%", gap: 2 }} onKeyPress={handleKeyPress}>
          <FormControl>
            <FormLabel htmlFor="email">Email</FormLabel>
            <TextField
              error={!!errors.email}
              helperText={errors.email}
              id="email"
              type="email"
              name="email"
              placeholder="your@email.com"
              autoComplete="email"
              autoFocus
              required
              fullWidth
              variant="outlined"
              value={formData.email}
              onChange={handleInputChange}
              color={errors.email ? "error" : "primary"}
            />
          </FormControl>
          <FormControl>
            <Box sx={{ display: "flex", justifyContent: "space-between" }}>
              <FormLabel htmlFor="password">Password</FormLabel>
              <Link component="button" type="button" onClick={() => setOpen(true)} variant="body2" sx={{ alignSelf: "baseline" }}>
                Forgot your password?
              </Link>
            </Box>
            <TextField
              error={!!errors.password}
              helperText={errors.password}
              name="password"
              placeholder="••••••"
              type={showPassword ? 'text' : 'password'}
              id="password"
              autoComplete="current-password"
              required
              fullWidth
              variant="outlined"
              value={formData.password}
              onChange={handleInputChange}
              color={errors.password ? "error" : "primary"}
              InputProps={{
                endAdornment: (
                  <InputAdornment position="end">
                    <IconButton
                      aria-label="toggle password visibility"
                      onClick={handleClickShowPassword}
                      onMouseDown={handleMouseDownPassword}
                      edge="end"
                    >
                      {showPassword ? <VisibilityOff /> : <Visibility />}
                    </IconButton>
                  </InputAdornment>
                ),
              }}
            />
          </FormControl>
          <FormControlLabel control={<Checkbox value="remember" color="primary" />} label="Remember me" />
          <ForgotPassword open={open} handleClose={() => setOpen(false)} />
          <Button type="submit" fullWidth variant="contained">
            Sign in
          </Button>
          <Typography sx={{ textAlign: "center" }}>
            Don't have an account?{" "}
            <Link href="/sign-up" variant="body2" sx={{ alignSelf: "center" }} onClick={(e) => { e.preventDefault(); navigate("/sign-up"); }}>
              Sign up
            </Link>
          </Typography>
        </Box>
        <Divider>or</Divider>
        <Box sx={{ display: "flex", flexDirection: "column", gap: 2 }}>
          <Button fullWidth variant="outlined" onClick={() => alert("Sign in with Google")} startIcon={<GoogleIcon />}>
            Sign in with Google
          </Button>
          <Button fullWidth variant="outlined" onClick={() => alert("Sign in with Facebook")} startIcon={<FacebookIcon />}>
            Sign in with Facebook
          </Button>
        </Box>
      </Card>
    </SignInContainer>
  );
}
