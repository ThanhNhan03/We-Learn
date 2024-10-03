import React from 'react';
import {
  Button,
  Typography,
  Container,
  Paper,
  Box,
} from '@mui/material';
import { useTheme } from '@mui/material/styles';
import { useNavigate } from 'react-router-dom';
import CheckCircleOutlineIcon from '@mui/icons-material/CheckCircleOutline';

const ConfirmEmail = () => {
  const navigate = useNavigate();
  const theme = useTheme();

  const handleBackToLogin = () => {
    navigate('/sign-in');
  };

  return (
    <Container maxWidth="sm">
      <Paper elevation={6} sx={{ 
        borderRadius: theme.spacing(3),
        padding: theme.spacing(6),
        mt: 12,
        textAlign: 'center',
        background: `linear-gradient(145deg, ${theme.palette.background.paper}, ${theme.palette.grey[100]})`,
        boxShadow: '0 10px 30px rgba(0, 0, 0, 0.5)',
      }}>
        <img 
          src="https://th.bing.com/th/id/R.d79301bb563e48a3b918d22db4772b0b?rik=RVQRBR9zFC%2b09w&riu=http%3a%2f%2fdigitalunite.com%2fsites%2fdefault%2ffiles%2fimages%2fshutterstock_182236523.jpg&ehk=KW8dk3J8md2xTNCCrBSIY408Je3c7iuqj8cEE8hIJbw%3d&risl=&pid=ImgRaw&r=0" 
          alt="Email Icon" 
          style={{ width: '200px', marginBottom: '20px' }} 
        />
        <Typography variant="h4" sx={{ mb: 3, fontWeight: 'bold' }}>
          Request confirmed successfully
        </Typography>
        <Typography variant="body1" sx={{ mb: 5, color: theme.palette.text.secondary }}>
          Your registration request has been confirmed successfully and is now awaiting administrator approval. You will receive a confirmation email as soon as your request is approved.
        </Typography>
        <Button
          variant="contained"
          onClick={handleBackToLogin}
          sx={{
            bgcolor: theme.palette.primary.main,
            '&:hover': { bgcolor: theme.palette.primary.dark },
            textTransform: 'none',
            borderRadius: '30px',
            py: 1.5,
            px: 4,
            fontSize: '1rem',
            fontWeight: 'bold',
            boxShadow: '0 4px 10px rgba(0, 0, 0, 0.15)',
            transition: 'all 0.3s ease',
          }}
        >
          Back to Login Page
        </Button>
      </Paper>
    </Container>
  );
};

export default ConfirmEmail;