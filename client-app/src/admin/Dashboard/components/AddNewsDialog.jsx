import React, { useContext, useState, useEffect } from 'react';
import { Dialog, DialogTitle, DialogContent, DialogActions, TextField, Button, Typography } from '@mui/material';
import { AdminContext } from '../../../contexts/AdminContext';

const AddNewsDialog = ({ open, onClose, news, onChange, onSave, isEditing, error, setError }) => {
  const { admin } = useContext(AdminContext);
  const [createdAt, setCreatedAt] = useState(new Date().toISOString());

  useEffect(() => {
    if (!isEditing) {
      setCreatedAt(new Date().toISOString());
    }
  }, [open, isEditing]);

  const handleSave = async () => {
    try {
      setError(null);
      const newsData = {
        title: news.title,
        content: news.content,
        adminId: admin.id,
        createdAt: createdAt
      };
      await onSave(newsData);
    } catch (error) {
      setError('Some thing wrong when saving news');
    }
  };

  return (
    <Dialog open={open} onClose={onClose}>
      <DialogTitle>{isEditing ? 'Update News' : 'Add News'}</DialogTitle>
      <DialogContent>
        <TextField
          name="title"
          label="Title"
          fullWidth
          margin="dense"
          value={news.title}
          onChange={onChange}
          inputProps={{ maxLength: 50 }}
        />
        <TextField
          name="content"
          label="Content"
          fullWidth
          margin="dense"
          multiline
          rows={4}  
          value={news.content}
          onChange={onChange}
          inputProps={{ maxLength: 255 }}
        />
        {!isEditing && (
          <TextField
            label="Date"
            fullWidth
            margin="dense"
              value={new Date(createdAt).toLocaleString('vi-VN')}
              InputProps={{ readOnly: true }}
          />
        )}
      </DialogContent>
      <DialogActions>
        <Button onClick={onClose}>Hủy</Button>
        <Button onClick={handleSave} variant="contained" color="primary">
          {isEditing ? 'Update' : 'Add'}
        </Button>
      </DialogActions>
      {error && <Typography color="error">{error}</Typography>}
    </Dialog>
  );
};

export default AddNewsDialog;
