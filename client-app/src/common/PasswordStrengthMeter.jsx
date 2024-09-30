import React from 'react';
import { Box, LinearProgress, Typography } from '@mui/material';

const PasswordStrengthMeter = ({ password }) => {
  const calculateStrength = (password) => {
    let strength = 0;
    if (password.length >= 8) strength += 25;
    if (/[A-Z]/.test(password)) strength += 25;
    if (/[a-z]/.test(password)) strength += 25;
    if (/[0-9]/.test(password)) strength += 12.5;
    if (/[^A-Za-z0-9]/.test(password)) strength += 12.5;
    return strength;
  };

  const getStrengthLabel = (strength) => {
    if (strength < 50) return 'Weak';
    if (strength < 75) return 'Moderate';
    if (strength < 100) return 'Strong';
    return 'Very Strong';
  };

  const strength = calculateStrength(password);
  const label = getStrengthLabel(strength);

  return (
    <Box sx={{ width: '100%', mt: 1 }}>
      <LinearProgress variant="determinate" value={strength} />
      <Typography variant="caption" sx={{ mt: 0.5 }}>
        Password Strength: {label}
      </Typography>
    </Box>
  );
};

export default PasswordStrengthMeter;