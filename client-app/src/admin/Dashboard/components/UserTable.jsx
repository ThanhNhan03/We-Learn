import React, { useState, useEffect } from 'react';
import {
  Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper, Avatar,
  IconButton, Dialog, DialogTitle, DialogContent, DialogActions, Button, TextField, Typography
} from '@mui/material';
import { Visibility, Mail, Lock, LockOpen } from '@mui/icons-material';

const UserTable = ({ data, darkMode, handleToggleUserAccount }) => {
  const [openDetailDialog, setOpenDetailDialog] = useState(false);
  const [openEmailDialog, setOpenEmailDialog] = useState(false);
  const [openConfirmDialog, setOpenConfirmDialog] = useState(false);
  const [selectedUser, setSelectedUser] = useState(null);
  const [emailContent, setEmailContent] = useState('');
  const [actionType, setActionType] = useState(''); // 'lock' or 'unlock'

  // Check if data is an array
  useEffect(() => {
    if (!Array.isArray(data)) {
      console.error("Expected data to be an array, but got:", data);
      return; // Handle error appropriately
    }
  }, [data]);

  const handleOpenDetailDialog = (user) => {
    setSelectedUser(user);
    setOpenDetailDialog(true);
  };

  const handleOpenEmailDialog = (user) => {
    setSelectedUser(user);
    setEmailContent('');
    setOpenEmailDialog(true);
  };

  const handleOpenConfirmDialog = (user, type) => {
    setSelectedUser(user);
    setActionType(type);
    setOpenConfirmDialog(true);
  };

  const handleCloseDialog = () => {
    setOpenDetailDialog(false);
    setOpenEmailDialog(false);
    setOpenConfirmDialog(false);
    setSelectedUser(null);
    setEmailContent('');
  };

  const handleConfirmToggleAccountStatus = () => {
    const updatedUser = { ...selectedUser, status: !selectedUser.status };
    handleToggleUserAccount(updatedUser);
    handleCloseDialog();
  };

  return (
    <>
      <TableContainer component={Paper} sx={{ backgroundColor: darkMode ? '#424242' : '#fff', color: darkMode ? '#fff' : '#000' }}>
        <Table sx={{ minWidth: 650 }} aria-label="user table">
          <TableHead>
            <TableRow>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Avatar</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Name</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Email</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Phone</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Birthday</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Gender</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Status</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Actions</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {Array.isArray(data) && data.length > 0 ? (
              data.map((item, index) => (
                <TableRow key={index}>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>
                    {item.avatar ? <Avatar src={item.avatar} /> : <Avatar />}
                  </TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.name || 'No name'}</TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.email || 'No email'}</TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.phone || 'No phone number'}</TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.birthday || 'No birthday'}</TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.gender || 'No gender'}</TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.status ? 'Active' : 'Inactive'}</TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>
                    <IconButton onClick={() => handleOpenDetailDialog(item)} aria-label="view details">
                      <Visibility />
                    </IconButton>
                    <IconButton onClick={() => handleOpenEmailDialog(item)} aria-label="send email">
                      <Mail />
                    </IconButton>
                    <IconButton onClick={() => handleOpenConfirmDialog(item, item.status ? 'lock' : 'unlock')} aria-label="toggle account status">
                      {item.status ? <Lock /> : <LockOpen />}
                    </IconButton>
                  </TableCell>
                </TableRow>
              ))
            ) : (
              <TableRow>
                <TableCell colSpan={8} sx={{ textAlign: 'center', color: darkMode ? '#fff' : '#000' }}>
                  No data to display.
                </TableCell>
              </TableRow>
            )}
          </TableBody>
        </Table>
      </TableContainer>

      {selectedUser && (
        <Dialog open={openDetailDialog} onClose={handleCloseDialog}>
          <DialogTitle>Detail Information</DialogTitle>
          <DialogContent>
            <Avatar src={selectedUser.avatar} sx={{ width: 56, height: 56 }} />
            <p>ID: {selectedUser.id}</p>
            <p>Full Name: {selectedUser.name}</p>
            <p>Email: {selectedUser.email}</p>
            <p>Phone Number: {selectedUser.phone}</p>
            <p>Birthday: {selectedUser.birthday}</p>
            <p>Gender: {selectedUser.gender}</p>
          </DialogContent>
          <DialogActions>
            <Button onClick={handleCloseDialog}>Close</Button>
          </DialogActions>
        </Dialog>
      )}

      {selectedUser && (
        <Dialog open={openEmailDialog} onClose={handleCloseDialog}>
          <DialogTitle>Send email to {selectedUser.email}</DialogTitle>
          <DialogContent>
            <TextField
              label="Email content"
              multiline
              rows={4}
              fullWidth
              value={emailContent}
              onChange={(e) => setEmailContent(e.target.value)}
              placeholder="Enter email content..."
            />
          </DialogContent>
          <DialogActions>
            <Button onClick={handleCloseDialog}>Cancel</Button>
            <Button onClick={() => {
              console.log(`Sending email to: ${selectedUser.email} with content: ${emailContent}`);
              handleCloseDialog();
            }} color="primary">
              Send
            </Button>
          </DialogActions>
        </Dialog>
      )}

      {selectedUser && (
        <Dialog open={openConfirmDialog} onClose={handleCloseDialog}>
          <DialogTitle>Confirm</DialogTitle>
          <DialogContent>
            <Typography>
              {`Are you sure you want to ${actionType === 'lock' ? 'lock' : 'unlock'} the account of user ${selectedUser.name}?`}
            </Typography>
          </DialogContent>
          <DialogActions>
            <Button onClick={handleCloseDialog}>Cancel</Button>
            <Button onClick={handleConfirmToggleAccountStatus} color="primary">
              Confirm
            </Button>
          </DialogActions>
        </Dialog>
      )}
    </>
  );
};

// Sample data for testing
const testData = [
  { id: 1, name: 'Nguyen Van A', email: 'a@example.com', phone: '0123456789', birthday: '1990-01-01', gender: 'Male', status: true, avatar: null },
  { id: 2, name: 'Tran Thi B', email: 'b@example.com', phone: '0987654321', birthday: '1992-02-02', gender: 'Female', status: false, avatar: null },
  { id: 3, name: 'Le Van C', email: 'c@example.com', phone: '0912345678', birthday: '1985-03-03', gender: 'Male', status: true, avatar: null },
];

// Use testData in the UserTable component
<UserTable data={testData} darkMode={true} handleToggleUserAccount={(user) => console.log(user)} />

export default UserTable;
