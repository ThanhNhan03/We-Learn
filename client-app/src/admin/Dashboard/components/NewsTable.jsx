import React, { useState, useEffect } from 'react';
import { Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper, IconButton, Button, TextField, Select, MenuItem, FormControl, InputLabel, Pagination, Typography } from '@mui/material';
import { Edit, Delete } from '@mui/icons-material';
import AddNewsDialog from './AddNewsDialog';
import ConfirmDialog from '../../../common/ConfirmDialog';
import api from '../../../api/AxiosAPI';
// import { format } from 'date-fns';

const NewsTable = ({ darkMode }) => {
  const [news, setNews] = useState([]);
  const [pageNumber, setPageNumber] = useState(1);
  const [pageSize, setPageSize] = useState(10);
  const [sortBy, setSortBy] = useState('title');
  const [isDescending, setIsDescending] = useState(true);
  const [titleFilter, setTitleFilter] = useState('');
  const [totalPages, setTotalPages] = useState(1);
  const [openDialog, setOpenDialog] = useState(false);
  const [currentNews, setCurrentNews] = useState({ title: '', content: '', author: '', date: '' });
  const [isEditing, setIsEditing] = useState(false);
  const [confirmDialogOpen, setConfirmDialogOpen] = useState(false);
  const [newsToDelete, setNewsToDelete] = useState(null);
  const [error, setError] = useState(null);

  const formatDate = (dateString) => {
    if (!dateString) return '';
    try {
      return format(new Date(dateString), 'dd/MM/yyyy HH:mm');
    } catch (error) {
      console.error('Invalid date:', dateString);
      return '';
    }
  };

  useEffect(() => {
    fetchNews();  
  }, [pageNumber, pageSize, sortBy, isDescending, titleFilter]);

  const fetchNews = async () => {
    try {
      const url = `/News?pageNumber=${pageNumber}&pageSize=${pageSize}&sortBy=${sortBy}&isDescending=${isDescending}${titleFilter ? `&titleFilter=${encodeURIComponent(titleFilter)}` : ''}`;
      const response = await api.get(url);
      setNews(response.data.data.items.map(item => ({
        ...item,
        id: item.id
      })));
      setTotalPages(response.data.data.totalPages);
    } catch (error) {
      setError('Lỗi khi tải tin tức');
    }
  };

  const handleSearchChange = (event) => {
    setTitleFilter(event.target.value);
    setPageNumber(1);
  };

  const handleSortChange = (event) => {
    setSortBy(event.target.value);
    setPageNumber(1);
  };

  const handleOrderChange = (event) => {
    setIsDescending(event.target.value === 'true');
    setPageNumber(1);
  };

  const handlePageChange = (event, value) => {
    setPageNumber(value);
  };

  const handlePageSizeChange = (event) => {
    setPageSize(Number(event.target.value));
    setPageNumber(1);
  };

  const handleOpenDialog = (newsItem = null) => {
    if (newsItem) {
      setCurrentNews({
        id: newsItem.id,
        title: newsItem.title,
        content: newsItem.content,
        author: newsItem.author,
        date: newsItem.date
      });
      setIsEditing(true);
    } else {
      setCurrentNews({ id: '', title: '', content: '', author: '', date: '' });
      setIsEditing(false);
    }
    setOpenDialog(true);
  };

  const handleCloseDialog = () => {
    setOpenDialog(false);
    setCurrentNews({ title: '', content: '', author: '', date: '' });
    setIsEditing(false);
  };

  const handleInputChange = (e) => {
    const { name, value } = e.target;
    setCurrentNews(prev => ({ ...prev, [name]: value }));
  };

  const handleSaveNews = async (newsData) => {
    try {
      if (isEditing) {
        await api.put(`/News/${currentNews.id}`, newsData);
      } else {
        await api.post('/News', newsData);
      }
      fetchNews();
      handleCloseDialog();
      setError(null);
    } catch (error) {
      setError(error.response?.data?.message || 'Something wrong when saving news ');
    }
  };

  const handleDeleteClick = (newsItem) => {
    setNewsToDelete(newsItem);
    setConfirmDialogOpen(true);
  };

  const handleConfirmDelete = async () => {
    if (newsToDelete) {
      try {
        await api.delete(`/News/${newsToDelete.id}`);
        fetchNews();
      } catch (error) {
        console.error('Error deleting news:', error);
      }
    }
    setConfirmDialogOpen(false);
    setNewsToDelete(null);
  };

  const handleCancelDelete = () => {
    setConfirmDialogOpen(false);
    setNewsToDelete(null);
  };

  return (
    <TableContainer component={Paper} sx={{ backgroundColor: darkMode ? '#424242' : '#fff', color: darkMode ? '#fff' : '#000' }}>
      <FormControl fullWidth sx={{ m: 1 }}>
        <TextField
          label="Search by title"
          variant="outlined"
          value={titleFilter}
          onChange={handleSearchChange}
        />
      </FormControl>
      <FormControl sx={{ m: 1, minWidth: 120 }}>
        <InputLabel>Sort by</InputLabel>
        <Select
          value={sortBy}
          label="Sort by"
          onChange={handleSortChange}
        >
          <MenuItem value="title">Title</MenuItem>
          <MenuItem value="adminName">Admin Name</MenuItem>
          <MenuItem value="createdAt">Created Date</MenuItem>
          <MenuItem value="updatedAt">Updated Date</MenuItem>
        </Select>
      </FormControl>
      <FormControl sx={{ m: 1, minWidth: 120 }}>
        <InputLabel>Order</InputLabel>
        <Select
          value={isDescending.toString()}
          label="Order"
          onChange={handleOrderChange}
        >
          <MenuItem value="true">Descending</MenuItem>
          <MenuItem value="false">Ascending</MenuItem>
        </Select>
      </FormControl>
      <Button variant="contained" onClick={() => handleOpenDialog()} sx={{ margin: 2 }}>
        Add News
      </Button>
      <Table sx={{ minWidth: 650 }} aria-label="news table">
        <TableHead>
          <TableRow>
            <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Title</TableCell>
            <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Admin Name</TableCell>
            <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Created Date</TableCell>
            <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Updated Date</TableCell>
            <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Actions</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {news.map((item) => (
            <TableRow key={item.id}>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.title || ''}</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.adminName || ''}</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.createdAt}</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.updatedAt}</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>
                <IconButton onClick={() => handleOpenDialog(item)}>
                  <Edit />
                </IconButton>
                <IconButton onClick={() => handleDeleteClick(item)}>
                  <Delete />
                </IconButton>
              </TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
      <FormControl sx={{ m: 1, minWidth: 120 }}>
        <InputLabel>Items per page</InputLabel>
        <Select
          value={pageSize}
          label="Items per page"
          onChange={handlePageSizeChange}
        >
          <MenuItem value={5}>5</MenuItem>
          <MenuItem value={10}>10</MenuItem>
          <MenuItem value={20}>20</MenuItem>
        </Select>
      </FormControl>
      <Pagination 
        count={totalPages} 
        page={pageNumber} 
        onChange={handlePageChange} 
        color="primary" 
        sx={{ margin: 2, display: 'flex', justifyContent: 'center' }}
      />
      <AddNewsDialog
        open={openDialog}
        onClose={handleCloseDialog}
        news={currentNews}
        onChange={handleInputChange}
        onSave={handleSaveNews}
        isEditing={isEditing}
        error={error}
        setError={setError}
      />
      <ConfirmDialog
        open={confirmDialogOpen}
        onClose={handleCancelDelete}
        onConfirm={handleConfirmDelete}
        title="Confrim Delete"
        content="Are you sure you want to delete this news?"
      />
      {error && <Typography color="error">{error}</Typography>}
    </TableContainer>
  );
};

export default NewsTable;