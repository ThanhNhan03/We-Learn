import React from 'react';
import { Dialog, DialogTitle, DialogContent, DialogActions, Button, Typography } from '@mui/material';

const NewsDetailDialog = ({ open, onClose, news }) => {
  if (!news) return null;

  return (
    <Dialog open={open} onClose={onClose} maxWidth="md" fullWidth>
      <DialogTitle>{news.title}</DialogTitle>
      <DialogContent>
        <Typography variant="body1" paragraph>
          <strong>Content:</strong> {news.content}
        </Typography>
        <Typography variant="body2">
          <strong>Author:</strong> {news.adminName}
        </Typography>
        <Typography variant="body2">
          <strong>Created Date:</strong> {news.createdAt}
        </Typography>
        <Typography variant="body2">
          <strong>Updated Date:</strong> {news.updatedAt}
        </Typography>
      </DialogContent>
      <DialogActions>
        <Button onClick={onClose} color="primary">
          Close
        </Button>
      </DialogActions>
    </Dialog>
  );
};

export default NewsDetailDialog;