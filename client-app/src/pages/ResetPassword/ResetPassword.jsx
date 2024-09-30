import React, { useState, useEffect } from "react";
import { useNavigate, useLocation } from "react-router-dom";
import {
  TextField,
  Button,
  Typography,
  Box,
  Alert,
  Stack,
  Card as MuiCard,
  IconButton,
  FormControl,
  FormLabel,
} from "@mui/material";
import { styled } from "@mui/material/styles";
import ArrowBackIcon from '@mui/icons-material/ArrowBack';
import api from "../../api/AxiosAPI";
import { toast, ToastContainer } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import LoadingOverlay from "../../common/LoadingOverlay";

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

const ResetPasswordContainer = styled(Stack)(({ theme }) => ({
  padding: 20,
  marginTop: "10vh",
  fontFamily: "Arial, sans-serif",
}));

const ResetPassword = () => {
  const [newPassword, setNewPassword] = useState("");
  const [confirmPassword, setConfirmPassword] = useState("");
  const [error, setError] = useState("");
  const [successMessage, setSuccessMessage] = useState("");
  const [loading, setLoading] = useState(false);
  const navigate = useNavigate();
  const location = useLocation();

  // Lấy token và email từ URL
  const queryParams = new URLSearchParams(location.search);
  const token = queryParams.get("token");
  const email = queryParams.get("email");

  useEffect(() => {
    if (!token || !email) {
      setError("Invalid reset link. Please check your email or request a new reset link.");
    }
  }, [token, email]);

  const handleSubmit = async (e) => {
    e.preventDefault();
    setLoading(true);
    setError("");

    if (newPassword !== confirmPassword) {
      setError("Passwords do not match");
      setLoading(false);
      return;
    }

    if (!token || !email) {
      setError("Invalid reset link.");
      setLoading(false);
      return;
    }

    try {
      const response = await api.post("/Password/reset-password", {
        token: token,
        email: email,  
        newPassword: newPassword,
      });

      if (response.status === 200) {
        toast.success("Password has been reset successfully");
        setTimeout(() => {
          navigate("/login");
        }, 2000);
      }
    } catch (error) {
      if (error.response && error.response.data) {
        toast.error(error.response.data.message || "Failed to reset password");
      } else {
        toast.error("An error occurred. Please try again.");
      }
    } finally {
      setLoading(false);
    }
  };

  return (
    <ResetPasswordContainer direction="column" justifyContent="space-between">
      <IconButton
        aria-label="back to sign in"
        onClick={() => navigate('/sign-in')}
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
          Reset Password
        </Typography>

        {error && <Alert severity="error">{error}</Alert>}
        {successMessage && <Alert severity="success">{successMessage}</Alert>}

        <Box component="form" onSubmit={handleSubmit} noValidate sx={{ display: "flex", flexDirection: "column", width: "100%", gap: 2 }}>
          <FormControl>
            <FormLabel htmlFor="newPassword">New Password</FormLabel>
            <TextField
              id="newPassword"
              type="password"
              name="newPassword"
              placeholder="••••••"
              autoComplete="new-password"
              required
              fullWidth
              variant="outlined"
              value={newPassword}
              onChange={(e) => setNewPassword(e.target.value)}
            />
          </FormControl>
          <FormControl>
            <FormLabel htmlFor="confirmPassword">Confirm Password</FormLabel>
            <TextField
              id="confirmPassword"
              type="password"
              name="confirmPassword"
              placeholder="••••••"
              autoComplete="new-password"
              required
              fullWidth
              variant="outlined"
              value={confirmPassword}
              onChange={(e) => setConfirmPassword(e.target.value)}
            />
          </FormControl>
          <Button type="submit" fullWidth variant="contained" color="primary" disabled={loading || !token || !email}>
            Reset Password
          </Button>
        </Box>
      </Card>
    </ResetPasswordContainer>
  );
};

export default ResetPassword;
