import React, { useContext } from 'react';
import {
  Dialog,
  DialogTitle,
  DialogContent,
  DialogActions,
  Button,
  TextField,
  Select,
  MenuItem,
  Box,
  FormControl,
  InputLabel,
} from '@mui/material';
import api from '../../../api/AxiosAPI'; 
import { AdminContext } from '../../../contexts/AdminContext'; 

const FAQDialog = ({ open, onClose, currentFAQ, setCurrentFAQ, onSave, categories }) => {
  const { admin } = useContext(AdminContext); 

  const handleSave = async () => {
    try {
      const adminId = admin?.id; 
      if (currentFAQ.id) {
        await api.put(`/faq/${currentFAQ.id}`, {
          faqQuestion: currentFAQ.question,
          faqAnswer: currentFAQ.answer,
          faqCategories: currentFAQ.category,
  
        });
      } else {
      
        await api.post('/faq', {
          faqQuestion: currentFAQ.question,
          faqAnswer: currentFAQ.answer,
          faqCategories: currentFAQ.category,
          adminId: adminId, 
        });
      }
      onSave();
    } catch (error) {
      console.error("Error saving FAQ:", error);
      alert("Failed to save FAQ. Please try again.");
    }
  };

  return (
    <Dialog open={open} onClose={onClose} fullWidth maxWidth="sm">
      <DialogTitle>{currentFAQ.id ? 'Edit FAQ' : 'Add New FAQ'}</DialogTitle>
      <DialogContent>
        <Box sx={{ display: 'flex', flexDirection: 'column', gap: 2, mt: 2 }}>
          <TextField
            label="Question"
            variant="outlined"
            fullWidth
            value={currentFAQ.question}
            onChange={(e) => setCurrentFAQ({ ...currentFAQ, question: e.target.value })}
          />
          <TextField
            label="Answer"
            variant="outlined"
            fullWidth
            multiline
            rows={4}
            value={currentFAQ.answer}
            onChange={(e) => setCurrentFAQ({ ...currentFAQ, answer: e.target.value })}
          />
          <FormControl fullWidth variant="outlined">
            <InputLabel id="category-select-label">Category</InputLabel>
            <Select
              labelId="category-select-label"
              value={currentFAQ.category || ''}
              onChange={(e) => setCurrentFAQ({ ...currentFAQ, category: e.target.value })}
              label="Category"
            >
              <MenuItem value="" disabled>
                Select Category
              </MenuItem>
              {categories.map((category) => (
                <MenuItem key={category} value={category}>
                  {category}
                </MenuItem>
              ))}
            </Select>
          </FormControl>
          {/* Input ẩn cho ID của admin */}
          <input type="hidden" value={admin?.id} />
        </Box>
      </DialogContent>
      <DialogActions>
        <Button onClick={onClose} color="primary">
          CANCEL
        </Button>
        <Button onClick={handleSave} color="primary">
          SAVE
        </Button>
      </DialogActions>
    </Dialog>
  );
};

export default FAQDialog;
