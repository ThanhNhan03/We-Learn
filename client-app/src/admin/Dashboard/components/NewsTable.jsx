import React, { useState } from 'react';
import { Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper, IconButton, Button, Dialog, DialogTitle, DialogContent, DialogActions } from '@mui/material';
import { Edit, Delete } from '@mui/icons-material';
import EditNewsDialog from './EditNewsDialog';
import AddNewsDialog from './AddNewsDialog.jsx'; // Import AddNewsDialog component

const NewsTable = ({ data, darkMode, handleEditNews, handleDeleteNews, handleAddNews }) => {
  const [openEditDialog, setOpenEditDialog] = useState(false);
  const [openAddDialog, setOpenAddDialog] = useState(false); // State to manage add news dialog
  const [openConfirmDialog, setOpenConfirmDialog] = useState(false); // State to manage confirm delete dialog
  const [selectedNews, setSelectedNews] = useState({
    id: '',
    title: '',
    content: '',
    author: '',
    date: ''
  });

  // State to store new news information
  const [newNews, setNewNews] = useState({
    id: '',
    title: '',
    content: '',
    author: '',
    date: ''
  });

  // Open edit dialog
  const handleOpenEditDialog = (news) => {
    setSelectedNews(news); // Set selected news data
    setOpenEditDialog(true); // Open dialog
  };

  // Close edit dialog
  const handleCloseEditDialog = () => {
    setOpenEditDialog(false);
    setSelectedNews({ id: '', title: '', content: '', author: '', date: '' }); // Reset data
  };

  // Open add news dialog
  const handleOpenAddDialog = () => {
    setOpenAddDialog(true);
  };

  // Close add news dialog
  const handleCloseAddDialog = () => {
    setOpenAddDialog(false);
    setNewNews({ id: '', title: '', content: '', author: '', date: '' }); // Reset data
  };

  // Open confirm delete dialog
  const handleOpenConfirmDialog = (news) => {
    setSelectedNews(news);
    setOpenConfirmDialog(true);
  };

  // Close confirm delete dialog
  const handleCloseConfirmDialog = () => {
    setOpenConfirmDialog(false);
    setSelectedNews({ id: '', title: '', content: '', author: '', date: '' }); // Reset data
  };

  // Handle changes in edit form
  const handleChange = (e) => {
    const { name, value } = e.target;
    setSelectedNews((prev) => ({
      ...prev,
      [name]: value,
    }));
  };

  // Handle changes in new news form
  const handleNewChange = (e) => {
    const { name, value } = e.target;
    setNewNews((prev) => ({
      ...prev,
      [name]: value,
    }));
  };

  // Update news
  const handleUpdateNews = () => {
    handleEditNews(selectedNews); // Call handleEditNews from props to update news
    handleCloseEditDialog(); // Close dialog after updating
  };

  // Add new news
  const handleAddNewNews = () => {
    handleAddNews(newNews); // Call handleAddNews from props to add new news
    handleCloseAddDialog(); // Close dialog after adding
  };

  // Confirm delete news
  const handleConfirmDeleteNews = () => {
    handleDeleteNews(selectedNews); // Call handleDeleteNews from props to delete news
    handleCloseConfirmDialog(); // Close dialog after deleting
  };

  return (
    <>
      <TableContainer component={Paper} sx={{ backgroundColor: darkMode ? '#424242' : '#fff', color: darkMode ? '#000' : '#000' }}>
        <Button variant="contained" onClick={handleOpenAddDialog} sx={{ margin: 2 }}>
          Add News
        </Button>
        <Table sx={{ minWidth: 650 }} aria-label="news table">
          <TableHead>
            <TableRow>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Title</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Content</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Author</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Date</TableCell>
              <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>Actions</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {data.map((item, index) => (
              <TableRow key={index}>
                <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.title || ''}</TableCell>
                <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.content || ''}</TableCell>
                <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.author || ''}</TableCell>
                <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>{item.date || ''}</TableCell>
                <TableCell sx={{ color: darkMode ? '#fff' : '#000' }}>
                  <IconButton onClick={() => handleOpenEditDialog(item)}>
                    <Edit />
                  </IconButton>
                  <IconButton onClick={() => handleOpenConfirmDialog(item)}>
                    <Delete />
                  </IconButton>
                </TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>

      {/* Use EditNewsDialog component */}
      <EditNewsDialog
        open={openEditDialog}
        onClose={handleCloseEditDialog}
        selectedNews={selectedNews}
        onChange={handleChange}
        onUpdate={handleUpdateNews}
      />

      {/* Use AddNewsDialog component */}
      <AddNewsDialog
        open={openAddDialog}
        onClose={handleCloseAddDialog}
        newNews={newNews}
        onChange={handleNewChange}
        onAdd={handleAddNewNews}
      />

      {/* Confirm delete dialog */}
      <Dialog open={openConfirmDialog} onClose={handleCloseConfirmDialog}>
        <DialogTitle>Confirm Deletion</DialogTitle>
        <DialogContent>
          <p>{`Are you sure you want to delete the news titled "${selectedNews.title}"?`}</p>
        </DialogContent>
        <DialogActions>
          <Button onClick={handleCloseConfirmDialog}>Cancel</Button>
          <Button onClick={handleConfirmDeleteNews} color="primary">Confirm</Button>
        </DialogActions>
      </Dialog>
    </>
  );
};

export default NewsTable;
