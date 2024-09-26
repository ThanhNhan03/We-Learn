import React, { useState, useEffect } from 'react';
import {
  Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper, Avatar,
  IconButton, Dialog, DialogTitle, DialogContent, DialogActions, Button, TextField, Typography
} from '@mui/material';
import { Visibility, Mail, Delete } from '@mui/icons-material';

const EducatorTable = ({ data, darkMode, handleDeleteEducator }) => {
  const [openDetailDialog, setOpenDetailDialog] = useState(false);
  const [openEmailDialog, setOpenEmailDialog] = useState(false);
  const [openConfirmDialog, setOpenConfirmDialog] = useState(false);
  const [selectedEducator, setSelectedEducator] = useState(null);
  const [emailContent, setEmailContent] = useState('');

  // Check if data is an array
  useEffect(() => {
    if (!Array.isArray(data)) {
      console.error("Expected data to be an array, but got:", data);
      return; // Handle error appropriately
    }
  }, [data]);

  const handleOpenDetailDialog = (educator) => {
    setSelectedEducator(educator);
    setOpenDetailDialog(true);
  };

  const handleOpenEmailDialog = (educator) => {
    setSelectedEducator(educator);
    setEmailContent('');
    setOpenEmailDialog(true);
  };

  const handleOpenConfirmDialog = (educator) => {
    setSelectedEducator(educator);
    setOpenConfirmDialog(true);
  };

  const handleCloseDialog = () => {
    setOpenDetailDialog(false);
    setOpenEmailDialog(false);
    setOpenConfirmDialog(false);
    setSelectedEducator(null);
    setEmailContent('');
  };

  const handleConfirmDeleteEducator = () => {
    handleDeleteEducator(selectedEducator);
    handleCloseDialog();
  };

  return (
    <>
      <TableContainer component={Paper} sx={{ backgroundColor: darkMode ? '#424242' : '#fff', color: darkMode ? '#fff' : '#000' }}>
        <Table sx={{ minWidth: 650 }} aria-label="educator table">
          <TableHead>
            <TableRow>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Avatar</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Name</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Email</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Phone</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Gender</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Status</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Role</TableCell>
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
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.gender || 'No gender'}</TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.status ? 'Active' : 'Inactive'}</TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.role || 'No role'}</TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>
                    <IconButton onClick={() => handleOpenDetailDialog(item)} aria-label="view details">
                      <Visibility />
                    </IconButton>
                    <IconButton onClick={() => handleOpenEmailDialog(item)} aria-label="send email">
                      <Mail />
                    </IconButton>
                    <IconButton onClick={() => handleOpenConfirmDialog(item)} aria-label="delete educator">
                      <Delete />
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

      {selectedEducator && (
        <Dialog open={openDetailDialog} onClose={handleCloseDialog}>
          <DialogTitle>Detail Information</DialogTitle>
          <DialogContent>
            <Avatar src={selectedEducator.avatar} sx={{ width: 56, height: 56 }} />
            <p>ID: {selectedEducator.id}</p>
            <p>Full Name: {selectedEducator.name}</p>
            <p>Email: {selectedEducator.email}</p>
            <p>Phone Number: {selectedEducator.phone}</p>
            <p>Gender: {selectedEducator.gender}</p>
          </DialogContent>
          <DialogActions>
            <Button onClick={handleCloseDialog}>Close</Button>
          </DialogActions>
        </Dialog>
      )}

      {selectedEducator && (
        <Dialog open={openEmailDialog} onClose={handleCloseDialog}>
          <DialogTitle>Send email to {selectedEducator.email}</DialogTitle>
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
              console.log(`Sending email to: ${selectedEducator.email} with content: ${emailContent}`);
              handleCloseDialog();
            }} color="primary">
              Send
            </Button>
          </DialogActions>
        </Dialog>
      )}

      {selectedEducator && (
        <Dialog open={openConfirmDialog} onClose={handleCloseDialog}>
          <DialogTitle>Confirm Deletion</DialogTitle>
          <DialogContent>
            <Typography>
              {`Are you sure you want to delete the account of educator ${selectedEducator.name}?`}
            </Typography>
          </DialogContent>
          <DialogActions>
            <Button onClick={handleCloseDialog}>Cancel</Button>
            <Button onClick={handleConfirmDeleteEducator} color="primary">
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
  { id: 1, name: "Nguyễn Văn A", email: "educatorA@example.com", phone: "123456789", gender: "Male", status: true, role: "Teacher" },
  { id: 2, name: "Trần Thị B", email: "educatorB@example.com", phone: "987654321", gender: "Female", status: false, role: "Assistant" },
  { id: 3, name: "Lê Văn C", email: "educatorC@example.com", phone: "456789123", gender: "Male", status: true, role: "Professor" },
];

// Use testData in the EducatorTable component
<EducatorTable data={testData} darkMode={true} handleDeleteEducator={(educator) => console.log('Deleting educator:', educator)} />

export default EducatorTable;