import React from 'react';
import { Dialog, DialogTitle, DialogContent, DialogActions, TextField, Button } from '@mui/material';

const EditNewsDialog = ({ open, onClose, selectedNews, onChange, onUpdate }) => {
  return (
    <Dialog open={open} onClose={onClose}>
      <DialogTitle>Chỉnh sửa Tin Tức</DialogTitle>
      <DialogContent>
        <TextField
          name="title"
          label="Title"
          fullWidth
          margin="dense"
          value={selectedNews.title}
          onChange={onChange}
        />
        <TextField
          name="content"
          label="Content"
          fullWidth
          margin="dense"
          multiline
          rows={4}
          value={selectedNews.content}
          onChange={onChange}
        />
        <TextField
          name="author"
          label="Author"
          fullWidth
          margin="dense"
          value={selectedNews.author}
          onChange={onChange}
        />
        <TextField
          name="date"
          label="Date"
          fullWidth
          margin="dense"
          type="date"
          InputLabelProps={{ shrink: true }}
          value={selectedNews.date}
          onChange={onChange}
        />
      </DialogContent>
      <DialogActions>
        <Button onClick={onClose}>Hủy</Button>
        <Button onClick={onUpdate} variant="contained" color="primary">
          Cập nhật
        </Button>
      </DialogActions>
    </Dialog>
  );
};

export default EditNewsDialog;
