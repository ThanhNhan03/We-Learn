import React, { useState, useEffect } from 'react';
import {
  Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper, Avatar,
  IconButton, Dialog, DialogTitle, DialogContent, DialogActions, Button, TextField, Typography,
  LinearProgress, Select, MenuItem, FormControl, InputLabel, Pagination, Box
} from '@mui/material';
import { Visibility, Mail, Delete, Person } from '@mui/icons-material';
import api from '../../../api/AxiosAPI';

const EducatorTable = ({ darkMode }) => {
  const [data, setData] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);
  const [openDetailDialog, setOpenDetailDialog] = useState(false);
  const [openEmailDialog, setOpenEmailDialog] = useState(false);
  const [openConfirmDialog, setOpenConfirmDialog] = useState(false);
  const [selectedEducator, setSelectedEducator] = useState(null);
  const [emailContent, setEmailContent] = useState('');
  const [pageNumber, setPageNumber] = useState(1);
  const [pageSize, setPageSize] = useState(10);
  const [filter, setFilter] = useState('');
  const [sortOrder, setSortOrder] = useState('');
  const [totalPages, setTotalPages] = useState(0);
  const [searchTerm, setSearchTerm] = useState('');

  useEffect(() => {
    const fetchData = async () => {
      try {
        setLoading(true);
        const response = await api.get(`/Admin/teachers?pageNumber=${pageNumber}&pageSize=${pageSize}&filter=${filter}&sortOrder=${sortOrder}`);
        setData(response.data.items);
        setTotalPages(response.data.totalPages);
        console.log(response.data);
      } catch (err) {
        setError(err.message);
      } finally {
        setLoading(false);
      }
    };
    fetchData();
  }, [pageNumber, pageSize, filter, sortOrder]);

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

  const handleDeleteEducator = (educator) => {
    console.log('Deleting educator:', educator);
    // Implement the actual delete logic here
    handleCloseDialog();
  };

  const handleChangePage = (event, newPage) => {
    setPageNumber(newPage);
  };

  const handleChangeRowsPerPage = (event) => {
    setPageSize(parseInt(event.target.value, 10));
    setPageNumber(1);
  };

  const handleFilterChange = (e) => {
    setSearchTerm(e.target.value);
  };

  const handleSearch = () => {
    setFilter(searchTerm);
    setPageNumber(1);
  };

  const handleSortOrderChange = (event) => {
    setSortOrder(event.target.value);
    setPageNumber(1);
  };

  if (loading) {
    return <LinearProgress style={{ width: '100%', color: 'red' }}/>;
  }

  if (error) {
    return <p>Error: {error}</p>;
  }

  return (
    <>
      <Box sx={{ mb: 2, display: 'flex', gap: '10px' }}>
        <TextField
          label="Search"
          variant="outlined"
          value={searchTerm}
          onChange={handleFilterChange}
          sx={{ width: '300px' }}
        />
        <Button 
          variant="contained" 
          onClick={handleSearch}
          style={{ height: '40px' }}
        >
          Search
        </Button>
        <FormControl variant="outlined" sx={{ minWidth: 120 }}>
          <InputLabel>Sort Order</InputLabel>
          <Select
            value={sortOrder}
            onChange={handleSortOrderChange}
            label="Sort Order"
          >
            <MenuItem value="">None</MenuItem>
            <MenuItem value="firstname">First Name (A-Z)</MenuItem>
            <MenuItem value="firstname_desc">First Name (Z-A)</MenuItem>
            <MenuItem value="lastname">Last Name (A-Z)</MenuItem>
            <MenuItem value="lastname_desc">Last Name (Z-A)</MenuItem>
          </Select>
        </FormControl>
      </Box>

      <TableContainer component={Paper} sx={{ backgroundColor: darkMode ? '#424242' : '#fff', color: darkMode ? '#fff' : '#000' }}>
        <Table sx={{ minWidth: 650 }} aria-label="admin table">
          <TableHead>
            <TableRow>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Avatar</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Name</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Email</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Actions</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {data.length > 0 ? (
              data.map((item, index) => (
                <TableRow key={index}>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>
                    {item.avatarUrl ? (
                      <Avatar src={item.avatarUrl} alt={`${item.firstName} ${item.lastName}`} />
                    ) : (
                      <Avatar>
                        <Person />
                      </Avatar>
                    )}
                  </TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{`${item.firstName} ${item.lastName}` || 'No name'}</TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.email || 'No email'}</TableCell>
                  <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>
                    <IconButton onClick={() => handleOpenDetailDialog(item)} aria-label="view details">
                      <Visibility />
                    </IconButton>
                    <IconButton onClick={() => handleOpenEmailDialog(item)} aria-label="send email">
                      <Mail />
                    </IconButton>
                    <IconButton onClick={() => handleOpenConfirmDialog(item)} aria-label="delete admin">
                      <Delete />
                    </IconButton>
                  </TableCell>
                </TableRow>
              ))
            ) : (
              <TableRow>
                <TableCell colSpan={4} sx={{ textAlign: 'center', color: darkMode ? '#fff' : '#000' }}>
                  No data to display.
                </TableCell>
              </TableRow>
            )}
          </TableBody>
        </Table>
      </TableContainer>

      <Box sx={{ mt: 2, display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
        <FormControl variant="outlined" sx={{ minWidth: 120 }}>
          <InputLabel>Rows per page</InputLabel>
          <Select
            value={pageSize}
            onChange={handleChangeRowsPerPage}
            label="Rows per page"
          >
            <MenuItem value={5}>5</MenuItem>
            <MenuItem value={10}>10</MenuItem>
            <MenuItem value={25}>25</MenuItem>
          </Select>
        </FormControl>
        <Pagination
          count={totalPages}
          page={pageNumber}
          onChange={handleChangePage}
          color="primary"
        />
      </Box>

      {selectedEducator && (
        <>
          <Dialog open={openDetailDialog} onClose={handleCloseDialog}>
            <DialogTitle>Admin Details</DialogTitle>
            <DialogContent>
              <p>ID: {selectedEducator.id}</p>
              <p>Full Name: {`${selectedEducator.firstName} ${selectedEducator.lastName}`}</p>
              <p>Email: {selectedEducator.email}</p>
              {/* Add more details as needed */}
            </DialogContent>
            <DialogActions>
              <Button onClick={handleCloseDialog}>Close</Button>
            </DialogActions>
          </Dialog>

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

          <Dialog open={openConfirmDialog} onClose={handleCloseDialog}>
            <DialogTitle>Confirm Deletion</DialogTitle>
            <DialogContent>
              <Typography>
                {`Are you sure you want to delete the admin account of ${selectedEducator.firstName} ${selectedEducator.lastName}?`}
              </Typography>
            </DialogContent>
            <DialogActions>
              <Button onClick={handleCloseDialog}>Cancel</Button>
              <Button onClick={() => handleDeleteEducator(selectedEducator)} color="primary">
                Confirm
              </Button>
            </DialogActions>
          </Dialog>
        </>
      )}
    </>
  );
};

export default EducatorTable;