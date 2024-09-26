import React, { useState } from 'react';
import { Table, TableBody, TableCell, TableContainer, TableHead, TableRow, Paper, IconButton, Button } from '@mui/material';
import { Edit, Delete } from '@mui/icons-material';
import EditNewsDialog from './EditNewsDialog';
import AddNewsDialog from './AddNewsDialog.jsx'; // Import thành phần AddNewsDialog

const NewsTable = ({ data, darkMode, handleEditNews, handleDeleteNews, handleAddNews }) => {
  const [openEditDialog, setOpenEditDialog] = useState(false);
  const [openAddDialog, setOpenAddDialog] = useState(false); // State quản lý dialog thêm tin tức
  const [selectedNews, setSelectedNews] = useState({
    id: '',
    title: '',
    content: '',
    author: '',
    date: ''
  });

  // State lưu trữ thông tin tin tức mới
  const [newNews, setNewNews] = useState({
    id: '',
    title: '',
    content: '',
    author: '',
    date: ''
  });

  // Mở dialog chỉnh sửa
  const handleOpenEditDialog = (news) => {
    setSelectedNews(news); // Gán dữ liệu của tin tức vào state
    setOpenEditDialog(true); // Mở dialog
  };

  // Đóng dialog chỉnh sửa
  const handleCloseEditDialog = () => {
    setOpenEditDialog(false);
    setSelectedNews({ id: '', title: '', content: '', author: '', date: '' }); // Reset dữ liệu
  };

  // Mở dialog thêm tin tức
  const handleOpenAddDialog = () => {
    setOpenAddDialog(true);
  };

  // Đóng dialog thêm tin tức
  const handleCloseAddDialog = () => {
    setOpenAddDialog(false);
    setNewNews({ id: '', title: '', content: '', author: '', date: '' }); // Reset dữ liệu
  };

  // Xử lý khi thay đổi dữ liệu trong form chỉnh sửa
  const handleChange = (e) => {
    const { name, value } = e.target;
    setSelectedNews((prev) => ({
      ...prev,
      [name]: value,
    }));
  };

  // Xử lý khi thay đổi dữ liệu trong form thêm mới
  const handleNewChange = (e) => {
    const { name, value } = e.target;
    setNewNews((prev) => ({
      ...prev,
      [name]: value,
    }));
  };

  // Cập nhật tin tức
  const handleUpdateNews = () => {
    handleEditNews(selectedNews); // Gọi hàm handleEditNews từ props để cập nhật tin tức
    handleCloseEditDialog(); // Đóng dialog sau khi cập nhật
  };

  // Thêm tin tức mới
  const handleAddNewNews = () => {
    handleAddNews(newNews); // Gọi hàm handleAddNews từ props để thêm tin tức mới
    handleCloseAddDialog(); // Đóng dialog sau khi thêm mới
  };

  return (
    <>
      <TableContainer component={Paper} sx={{ backgroundColor: darkMode ? '#424242' : '#fff', color: darkMode ? '#000' : '#000' }}>
        <Button variant="contained" onClick={handleOpenAddDialog} sx={{ margin: 2 }}>
          Thêm Tin Tức
        </Button>
        <Table sx={{ minWidth: 650 }} aria-label="simple table">
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
                  <IconButton onClick={() => handleDeleteNews(item)}>
                    <Delete />
                  </IconButton>
                </TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>

      {/* Sử dụng thành phần EditNewsDialog */}
      <EditNewsDialog
        open={openEditDialog}
        onClose={handleCloseEditDialog}
        selectedNews={selectedNews}
        onChange={handleChange}
        onUpdate={handleUpdateNews}
      />

      {/* Sử dụng thành phần AddNewsDialog */}
      <AddNewsDialog
        open={openAddDialog}
        onClose={handleCloseAddDialog}
        newNews={newNews}
        onChange={handleNewChange}
        onAdd={handleAddNewNews}
      />
    </>
  );
};

export default NewsTable;
