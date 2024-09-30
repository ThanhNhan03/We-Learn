import * as React from 'react';
import PropTypes from 'prop-types';
import Button from '@mui/material/Button';
import Dialog from '@mui/material/Dialog';
import DialogActions from '@mui/material/DialogActions';
import DialogContent from '@mui/material/DialogContent';
import DialogContentText from '@mui/material/DialogContentText';
import DialogTitle from '@mui/material/DialogTitle';
import OutlinedInput from '@mui/material/OutlinedInput';
import api from '../../api/AxiosAPI';
import { toast } from 'react-toastify';

function ForgotPassword({ open, handleClose }) {
  const [email, setEmail] = React.useState('');
  const [isLoading, setIsLoading] = React.useState(false);

  const handleSubmit = async (event) => {
    event.preventDefault();
    setIsLoading(true);
    try {
      const response = await api.post('/Password/forgot-password', { email });
      toast.success(response.data.message);
      handleClose();
    } catch (error) {
      toast.error(error.response?.data || 'An error occurred');
    } finally {
      setIsLoading(false);
    }
  };

  return (
    <Dialog
      open={open}
      onClose={handleClose}
      PaperProps={{
        component: 'form',
        onSubmit: handleSubmit,
      }}
      maxWidth="xs"
      fullWidth
    >
      <DialogTitle>Reset password</DialogTitle>
      <DialogContent
        sx={{ 
          display: 'flex', 
          flexDirection: 'column', 
          gap: 2,
          width: 'auto',
          p: 2,
        }}
      >
        <DialogContentText>
          Enter your account's email address, and we'll send you a link to
          reset your password.
        </DialogContentText>
        <OutlinedInput
          autoFocus
          required
          margin="dense"
          id="email"
          name="email"
          label="Email address"
          placeholder="Email address"
          type="email"
          fullWidth
          value={email}
          onChange={(e) => setEmail(e.target.value)}
        />
      </DialogContent>
      <DialogActions sx={{ pb: 3, px: 3 }}>
        <Button onClick={handleClose} disabled={isLoading}>Cancel</Button>
        <Button variant="contained" type="submit" disabled={isLoading}>
          {isLoading ? 'Processing...' : 'Continue'}
        </Button>
      </DialogActions>
    </Dialog>
  );
}

ForgotPassword.propTypes = {
  handleClose: PropTypes.func.isRequired,
  open: PropTypes.bool.isRequired,
};

export default ForgotPassword;