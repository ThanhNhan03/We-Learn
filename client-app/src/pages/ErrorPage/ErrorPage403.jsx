import React from "react";
import { Box, Typography, Button, Container } from "@mui/material";
import { styled } from "@mui/system";
import { FaExclamationTriangle } from "react-icons/fa";

const ErrorPageContainer = styled(Box)(({ theme }) => ({
  backgroundImage: "url('https://images.unsplash.com/photo-1534796636912-3b95b3ab5986?ixlib=rb-4.0.3&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=1920&q=80')",
  backgroundSize: "cover",
  backgroundPosition: "center",
  height: "100vh",
  display: "flex",
  flexDirection: "column",
  justifyContent: "center",
  alignItems: "center",
  position: "relative",
  "&::before": {
    content: '""',
    position: "absolute",
    top: 0,
    left: 0,
    right: 0,
    bottom: 0,
    backgroundColor: "rgba(0, 0, 0, 0.5)",
  },
}));

const ContentWrapper = styled(Container)(({ theme }) => ({
  position: "relative",
  zIndex: 1,
  textAlign: "center",
  color: "#ffffff",
  animation: "fadeIn 1s ease-in-out",
  "@keyframes fadeIn": {
    from: { opacity: 0, transform: "translateY(-20px)" },
    to: { opacity: 1, transform: "translateY(0)" },
  },
}));

const ErrorIcon = styled(FaExclamationTriangle)(({ theme }) => ({
  fontSize: "5rem",
  marginBottom: theme.spacing(2),
  color: "#ffa000", 
}));

const ErrorMessage = styled(Typography)(({ theme }) => ({
  marginBottom: theme.spacing(3),
  fontWeight: "bold",
}));

const StyledButton = styled(Button)(({ theme }) => ({
  transition: "all 0.3s ease-in-out",
  "&:hover": {
    transform: "scale(1.05)",
    boxShadow: "0px 4px 20px rgba(0, 0, 0, 0.25)",
  },
}));

const ErrorPage403 = () => {
  return (
    <ErrorPageContainer>
      <ContentWrapper maxWidth="sm">
        <ErrorIcon aria-hidden="true" />
        <ErrorMessage variant="h4" component="h1" gutterBottom>
        403 - Access Forbidden
        </ErrorMessage>
        <Typography variant="body1" paragraph>
        Oops! You don't have permission to access this page. If you believe this is an error, please contact the administrator.
        </Typography>
        <StyledButton
          variant="contained"
          color="primary"
          size="large"
          href="/"
          aria-label="Quay lại trang chủ"
        >
            Back to Home
        </StyledButton>
      </ContentWrapper>
    </ErrorPageContainer>
  );
};

export default ErrorPage403;