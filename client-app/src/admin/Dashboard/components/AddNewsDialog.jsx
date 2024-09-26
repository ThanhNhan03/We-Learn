import React from 'react';
import { Dialog, DialogTitle, DialogContent, DialogActions, TextField, Button } from '@mui/material';

const AddNewsDialog = ({ open, onClose, newNews, onChange, onAdd }) => {
  return (
    <Dialog open={open} onClose={onClose}>
      <DialogTitle>Thêm Tin Tức Mới</DialogTitle>
      <DialogContent>
        <TextField
          name="title"
          label="Title"
          fullWidth
          margin="dense"
          value={newNews.title}
          onChange={onChange}
        />
        <TextField
          name="content"
          label="Content"
          fullWidth
          margin="dense"
          multiline
          rows={4}
          value={newNews.content}
          onChange={onChange}
        />
        <TextField
          name="author"
          label="Author"
          fullWidth
          margin="dense"
          value={newNews.author}
          onChange={onChange}
        />
        <TextField
          name="date"
          label="Date"
          fullWidth
          margin="dense"
          type="date"
          InputLabelProps={{ shrink: true }}
          value={newNews.date}
          onChange={onChange}
        />
      </DialogContent>
      <DialogActions>
        <Button onClick={onClose}>Hủy</Button>
        <Button onClick={onAdd} variant="contained" color="primary">
          Thêm
        </Button>
      </DialogActions>
    </Dialog>
  );
};

export default AddNewsDialog;
