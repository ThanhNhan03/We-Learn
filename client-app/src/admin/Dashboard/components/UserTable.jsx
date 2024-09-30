import React, { useState, useEffect } from 'react';
import {
  Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper, Avatar,
  IconButton, TextField, Select, MenuItem, FormControl, InputLabel, Button, Dialog, DialogTitle, DialogContent, DialogActions, Typography,
  LinearProgress
} from '@mui/material';
import { Visibility, Mail, Lock, LockOpen } from '@mui/icons-material';
import api from '../../../api/AxiosAPI';

const UserTable = ({ darkMode }) => {
  const [data, setData] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);
  const [filter, setFilter] = useState('');
  const [sortOrder, setSortOrder] = useState('lastname_desc');
  const [pageNumber, setPageNumber] = useState(1);
  const [pageSize, setPageSize] = useState(10);
  const [openDetailDialog, setOpenDetailDialog] = useState(false);
  const [openEmailDialog, setOpenEmailDialog] = useState(false);
  const [openConfirmDialog, setOpenConfirmDialog] = useState(false);
  const [selectedUser, setSelectedUser] = useState(null);
  const [emailContent, setEmailContent] = useState('');
  const [actionType, setActionType] = useState('');
  const [searchTerm, setSearchTerm] = useState('');

  useEffect(() => {
    const fetchData = async () => {
      try {
        const response = await api.get(`/Admin/users?pageNumber=${pageNumber}&pageSize=${pageSize}&filter=${filter}&sortOrder=${sortOrder}`);
        setData(response.data.items);
        console.log(response.data.items);
      } catch (err) {
        setError(err.message);
      } finally {
        setLoading(false);
      }
    };
    fetchData();
  }, [filter, sortOrder, pageNumber, pageSize]);

  const handleFilterChange = (e) => {
    setSearchTerm(e.target.value);
  };

  const handleSearch = () => {
    setFilter(searchTerm);
  };

  const handleSortOrderChange = (e) => {
    setSortOrder(e.target.value);
  };

  const handlePageSizeChange = (e) => {
    setPageSize(e.target.value);
  };

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
    // Implement account status toggle logic here
    console.log(`Toggling account status for user: ${selectedUser.email}`);
    handleCloseDialog();
  };

  if (loading) {
    return <LinearProgress style={{ width: '100%', color: 'red' }}/>;
  }

  if (error) {
    return <p>Error: {error}</p>;
  }

  return (
    <div>
      {/* Filter, Sort, and Pagination Controls */}
      <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '20px' }}>
        <div style={{ display: 'flex', gap: '10px' }}>
          <TextField 
            label="Search" 
            value={searchTerm} 
            onChange={handleFilterChange} 
            variant="outlined" 
            size="small"
            sx={{ width: '300px' }}
          />
          <Button 
            variant="contained" 
            onClick={handleSearch}
            style={{ height: '40px' }}
          >
            Search
          </Button>
          <FormControl variant="outlined" size="small">
            <InputLabel>Sort</InputLabel>
            <Select value={sortOrder} onChange={handleSortOrderChange} label="Sort">
              <MenuItem value="lastname_desc">Last Name (Z-A)</MenuItem>
              <MenuItem value="lastname">Last Name (A-Z)</MenuItem>
              <MenuItem value="firstname_desc">First Name (Z-A)</MenuItem>
              <MenuItem value="firstname">First Name (A-Z)</MenuItem>
              <MenuItem value="email">Email</MenuItem>
              <MenuItem value="birthday">Birthday</MenuItem>
            </Select>
          </FormControl>
        </div>
        <div style={{ display: 'flex', gap: '10px', alignItems: 'center' }}>
          <FormControl variant="outlined" size="small">
            <InputLabel>Page Size</InputLabel>
            <Select value={pageSize} onChange={handlePageSizeChange} label="Page Size">
              <MenuItem value={5}>5</MenuItem>
              <MenuItem value={10}>10</MenuItem>
              <MenuItem value={20}>20</MenuItem>
            </Select>
          </FormControl>
          <Button variant="outlined" onClick={() => setPageNumber((prev) => Math.max(prev - 1, 1))}>Previous</Button>
          <Button variant="outlined" onClick={() => setPageNumber((prev) => prev + 1)}>Next</Button>
        </div>
      </div>

      {/* User Table */}
      <TableContainer component={Paper} sx={{ backgroundColor: darkMode ? '#424242' : '#fff', color: darkMode ? '#fff' : '#000' }}>
        <Table sx={{ minWidth: 650 }} aria-label="user table">
          <TableHead>
            <TableRow>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Avatar</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Name</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Email</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Birthday</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Gender</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Status</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Actions</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {data.length > 0 ? (
              data.map((item, index) => (
                <TableRow key={index}>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>
                    {item.image ? <Avatar src={item.image} /> : <Avatar />}
                  </TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>
                    {`${item.firstName || 'No'} ${item.lastName || 'name'}`}
                  </TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>
                    {item.email || 'No email'}
                  </TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>
                    {item.birthday || 'No birthday'}
                  </TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>
                    {item.gender || 'No gender'}
                  </TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>
                    {item.status ? 'Active' : 'Inactive'}
                  </TableCell>
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
                <TableCell colSpan={7} sx={{ textAlign: 'center', color: darkMode ? '#fff' : '#000' }}>
                  No data to display.
                </TableCell>
              </TableRow>
            )}
          </TableBody>
        </Table>
      </TableContainer>

      {/* Dialogs */}
      {selectedUser && (
        <>
          <Dialog open={openDetailDialog} onClose={handleCloseDialog}>
            <DialogTitle>User Details</DialogTitle>
            <DialogContent>
              <Avatar src={selectedUser.image} sx={{ width: 56, height: 56 }} />
              <p>ID: {selectedUser.id}</p>
              <p>Name: {`${selectedUser.firstName} ${selectedUser.lastName}`}</p>
              <p>Email: {selectedUser.email}</p>
              <p>Birthday: {selectedUser.birthday}</p>
              <p>Gender: {selectedUser.gender}</p>
            </DialogContent>
            <DialogActions>
              <Button onClick={handleCloseDialog}>Close</Button>
            </DialogActions>
          </Dialog>

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

          <Dialog open={openConfirmDialog} onClose={handleCloseDialog}>
            <DialogTitle>Confirm</DialogTitle>
            <DialogContent>
              <Typography>
                {`Are you sure you want to ${actionType === 'lock' ? 'lock' : 'unlock'} the account of ${selectedUser.firstName} ${selectedUser.lastName}?`}
              </Typography>
            </DialogContent>
            <DialogActions>
              <Button onClick={handleCloseDialog}>Cancel</Button>
              <Button onClick={handleConfirmToggleAccountStatus} color="primary">
                Confirm
              </Button>
            </DialogActions>
          </Dialog>
        </>
      )}
    </div>
  );
};

export default UserTable;