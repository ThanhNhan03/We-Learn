// We-Learn/client-app/src/components/SignIn.jsx
import * as React from "react";
import AxiosAPI from "../../api/AxiosAPI";  
import { Box, Button, Checkbox, CssBaseline, FormControlLabel, Divider, FormLabel, FormControl, Link, TextField, Typography, Stack, Card as MuiCard } from "@mui/material";
import { styled } from "@mui/material/styles";
import ForgotPassword from "./ForgotPassword";
import { GoogleIcon, FacebookIcon } from "./CustomIcons";
import { useNavigate } from "react-router-dom";

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
  const [emailError, setEmailError] = React.useState(false);
  const [emailErrorMessage, setEmailErrorMessage] = React.useState("");
  const [passwordError, setPasswordError] = React.useState(false);
  const [passwordErrorMessage, setPasswordErrorMessage] = React.useState("");
  const [open, setOpen] = React.useState(false);
  const navigate = useNavigate();

  const handleClickOpen = () => setOpen(true);
  const handleClose = () => setOpen(false);

  const validateInputs = () => {
    const email = document.getElementById("email").value;
    const password = document.getElementById("password").value;
    let isValid = true;

    if (!email || !/\S+@\S+\.\S+/.test(email)) {
      setEmailError(true);
      setEmailErrorMessage("Please enter a valid email address.");
      isValid = false;
    } else {
      setEmailError(false);
      setEmailErrorMessage("");
    }

    if (!password || password.length < 6) {
      setPasswordError(true);
      setPasswordErrorMessage("Password must be at least 6 characters long.");
      isValid = false;
    } else {
      setPasswordError(false);
      setPasswordErrorMessage("");
    }

    return isValid;
  };

  const handleSubmit = async (event) => {
    event.preventDefault();
    if (!validateInputs()) return;

    const data = new FormData(event.currentTarget);
    const loginData = {
      email: data.get("email"),
      password: data.get("password"),
    };

    try {
      const response = await AxiosAPI.post("/Auth/login", loginData);
      const { accessToken, refreshToken, role } = response.data;

      if (accessToken && refreshToken !== undefined) {
        localStorage.setItem("accessToken", accessToken);
        localStorage.setItem("refreshToken", refreshToken || "");
        navigate(role === "Admin" ? "/admin/dashboard" : "/");
      } else {
        throw new Error("Login response missing tokens");
      }
    } catch (error) {
      alert("Login failed: " + (error.response ? error.response.data : error.message));
    }
  };

  return (
    <>
      <CssBaseline enableColorScheme />
      <SignInContainer direction="column" justifyContent="space-between">
        <Card variant="outlined">
          <Typography component="h1" variant="h4" sx={{ width: "100%", fontSize: "clamp(2rem, 10vw, 2.15rem)" }}>
            Login
          </Typography>
          <Box component="form" onSubmit={handleSubmit} noValidate sx={{ display: "flex", flexDirection: "column", width: "100%", gap: 2 }}>
            <FormControl>
              <FormLabel htmlFor="email">Email</FormLabel>
              <TextField
                error={emailError}
                helperText={emailErrorMessage}
                id="email"
                type="email"
                name="email"
                placeholder="your@email.com"
                autoComplete="email"
                autoFocus
                required
                fullWidth
                variant="outlined"
                color={emailError ? "error" : "primary"}
              />
            </FormControl>
            <FormControl>
              <Box sx={{ display: "flex", justifyContent: "space-between" }}>
                <FormLabel htmlFor="password">Password</FormLabel>
                <Link component="button" onClick={handleClickOpen} variant="body2" sx={{ alignSelf: "baseline" }}>
                  Forgot your password?
                </Link>
              </Box>
              <TextField
                error={passwordError}
                helperText={passwordErrorMessage}
                name="password"
                placeholder="••••••"
                type="password"
                id="password"
                autoComplete="current-password"
                required
                fullWidth
                variant="outlined"
                color={passwordError ? "error" : "primary"}
              />
            </FormControl>
            <FormControlLabel control={<Checkbox value="remember" color="primary" />} label="Remember me" />
            <ForgotPassword open={open} handleClose={handleClose} />
            <Button type="submit" fullWidth variant="contained">Sign in</Button>
            <Typography sx={{ textAlign: "center" }}>
              Don&apos;t have an account?{" "}
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
    </>
  );
}
