import * as React from "react";
import { useState } from "react";
import { useForm } from "react-hook-form";
import Box from "@mui/material/Box";
import Button from "@mui/material/Button";
import Divider from "@mui/material/Divider";
import FormLabel from "@mui/material/FormLabel";
import FormControl from "@mui/material/FormControl";
import Link from "@mui/material/Link";
import TextField from "@mui/material/TextField";
import Typography from "@mui/material/Typography";
import Stack from "@mui/material/Stack";
import MuiCard from "@mui/material/Card";
import { createTheme, styled } from "@mui/material/styles";
import { GoogleIcon, FacebookIcon } from "./CustomIcons";
import PasswordStrengthMeter from '../../common/PasswordStrengthMeter';
import AxiosAPI from '../../api/AxiosAPI';
import { useNavigate } from 'react-router-dom';
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';
import * as yup from 'yup'; 
import { yupResolver } from "@hookform/resolvers/yup";

const Card = styled(MuiCard)(({ theme }) => ({
  display: "flex",
  flexDirection: "column",
  alignSelf: "center",
  width: "100%",
  padding: theme.spacing(4),
  gap: theme.spacing(2),
  margin: "auto",
  boxShadow:
    "hsla(220, 30%, 5%, 0.05) 0px 5px 15px 0px, hsla(220, 25%, 10%, 0.05) 0px 15px 35px -5px",
  [theme.breakpoints.up("sm")]: {
    width: "450px",
  },
  ...theme.applyStyles("dark", {
    boxShadow:
      "hsla(220, 30%, 5%, 0.5) 0px 5px 15px 0px, hsla(220, 25%, 10%, 0.08) 0px 15px 35px -5px",
  }),
}));

const schema = yup.object().shape({
  firstName: yup.string().required("First name is required"),
  lastName: yup.string().required("Last name is required"),
  email: yup.string().email("Invalid email").required("Email is required"),
  password: yup
    .string()
    .min(6, "Password must be at least 6 characters")
    .matches(
      /^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*(),.?":{}|<>])/,
      "Password must contain uppercase, lowercase, number and special character"
    )
    .required("Password is required"),
  confirmPassword: yup
    .string()
    .oneOf([yup.ref("password"), null], "Passwords do not match")
    .required("Confirm password is required"),
});

export default function SignUp() {
  const [password, setPassword] = useState("");
  const navigate = useNavigate();

  const {
    register,
    handleSubmit,
    formState: { errors },
  } = useForm({
    resolver: yupResolver(schema),
  });

  const onSubmit = async (data) => {
    try {
      const response = await AxiosAPI.post("/Auth/register/user", data);
      console.log("Registration successful:", response.data);
      toast.success("Registration successful. Please check your email to confirm your account.", {
        onClose: () => navigate('/sign-in')
      });
    } catch (error) {
      console.error("Registration error:", error.response?.data || error.message);
      toast.error("An error occurred during registration. Please try again.");
    }
  };

  const handlePasswordChange = (event) => {
    setPassword(event.target.value);
  };

  return (
    <Stack
      sx={{
        justifyContent: "center",
        height: "100dvh",
        p: 2,
      }}
    >
      <Card variant="outlined">
        <Typography
          component="h1"
          variant="h4"
          sx={{ width: "100%", fontSize: "clamp(2rem, 10vw, 2.15rem)" }}
        >
          Sign Up
        </Typography>
        <Box
          component="form"
          onSubmit={handleSubmit(onSubmit)}
          sx={{ display: "flex", flexDirection: "column", gap: 2 }}
        >
          <Box sx={{ display: "flex", gap: 2 }}>
            <FormControl sx={{ flex: 1 }}>
              <FormLabel htmlFor="firstName">First Name</FormLabel>
              <TextField
                {...register("firstName")}
                error={!!errors.firstName}
                helperText={errors.firstName?.message}
                placeholder="First Name"
              />
            </FormControl>
            <FormControl sx={{ flex: 1 }}>
              <FormLabel htmlFor="lastName">Last Name</FormLabel>
              <TextField
                {...register("lastName")}
                error={!!errors.lastName}
                helperText={errors.lastName?.message}
                placeholder="Last Name"
              />
            </FormControl>
          </Box>
          <FormControl>
            <FormLabel htmlFor="email">Email</FormLabel>
            <TextField
              {...register("email")}
              error={!!errors.email}
              helperText={errors.email?.message}
              placeholder="Email"
            />
          </FormControl>
          <FormControl>
            <FormLabel htmlFor="password">Password</FormLabel>
            <TextField
              {...register("password")}
              type="password"
              error={!!errors.password}
              helperText={errors.password?.message}
              onChange={(e) => {
                setPassword(e.target.value);
                register("password").onChange(e);
              }}
              placeholder="Password"
            />
            <PasswordStrengthMeter password={password} />
          </FormControl>
          <FormControl>
            <FormLabel htmlFor="confirmPassword">Confirm Password</FormLabel>
            <TextField
              {...register("confirmPassword")}
              type="password"
              error={!!errors.confirmPassword}
              helperText={errors.confirmPassword?.message}
              placeholder="Confirm Password"
            />
          </FormControl>
          <Button type="submit" fullWidth variant="contained">
            Sign Up
          </Button>
          <Typography sx={{ textAlign: "center" }}>
            Already have an account?{" "}
            <span>
              <Link
                href="sign-in"
                variant="body2"
                sx={{ alignSelf: "center" }}
              >
                Sign In
              </Link>
            </span>
          </Typography>
        </Box>
        <Divider>
          <Typography sx={{ color: "text.secondary" }}>or</Typography>
        </Divider>
        <Box sx={{ display: "flex", flexDirection: "column", gap: 2 }}>
          <Button
            type="submit"
            fullWidth
            variant="outlined"
            onClick={() => alert("Sign up with Google")}
            startIcon={<GoogleIcon />}
          >
            Sign up with Google
          </Button>
          <Button
            type="submit"
            fullWidth
            variant="outlined"
            onClick={() => alert("Sign up with Facebook")}
            startIcon={<FacebookIcon />}
          >
            Sign up with Facebook
          </Button>
        </Box>
      </Card>
      <ToastContainer position="top-right" autoClose={5000} />
    </Stack>
  );
}
