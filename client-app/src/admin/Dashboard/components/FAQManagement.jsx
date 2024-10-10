import React, { useState, useEffect, useCallback } from 'react';
import api from '../../../api/AxiosAPI';
import { 
  Container, 
  TextField, 
  Select, 
  MenuItem, 
  Button, 
  List, 
  ListItem, 
  ListItemText, 
  ListItemSecondaryAction, 
  IconButton,
  Typography,
  Box,
  Collapse,
  Pagination
} from '@mui/material';
import AddIcon from '@mui/icons-material/Add';
import EditIcon from '@mui/icons-material/Edit';
import DeleteIcon from '@mui/icons-material/Delete';
import ExpandMoreIcon from '@mui/icons-material/ExpandMore';
import ExpandLessIcon from '@mui/icons-material/ExpandLess';
import FAQDialog from './FAQDialog';
import { debounce } from 'lodash';

const FAQManagement = () => {
  const [searchTerm, setSearchTerm] = useState('');
  const [category, setCategory] = useState('All Categories');
  const [faqs, setFaqs] = useState([]); 
  const [categories, setCategories] = useState([]); 
  const [dialogOpen, setDialogOpen] = useState(false);
  const [currentFAQ, setCurrentFAQ] = useState({ question: '', answer: '', category: '' });
  const [filteredFAQs, setFilteredFAQs] = useState([]); 
  const [page, setPage] = useState(1);
  const [itemsPerPage] = useState(5);


  const fetchFAQs = async () => {
    try {
      const response = await api.get('/faq');
      const formattedFAQs = response.data.map(faq => ({
        id: faq.id,
        question: faq.faqQuestion,
        answer: faq.faqAnswer,
        category: faq.faqCategories,
        createdAt: new Date(faq.createdAt),
        expanded: false,
      }));
      setFaqs(formattedFAQs); 

      // Lấy danh sách categories từ response
      const uniqueCategories = [...new Set(response.data.map(faq => faq.faqCategories))];
      setCategories(['All Categories', ...uniqueCategories]); 
    } catch (error) {
      console.error("Error fetching FAQs:", error);
    }
  };

  useEffect(() => {
    fetchFAQs(); 
  }, []);

  const searchFAQs = useCallback((searchTerm, category, faqs) => {
    const keywords = searchTerm.toLowerCase().split(' ').filter(keyword => keyword.length > 0);
    
    return faqs
      .filter(faq => 
        (category === 'All Categories' || faq.category === category) &&
        (keywords.length === 0 || keywords.some(keyword => 
          faq.question.toLowerCase().includes(keyword) || 
          faq.answer.toLowerCase().includes(keyword)
        ))
      )
      .map(faq => ({
        ...faq,
        score: keywords.reduce((score, keyword) => {
          if (faq.question.toLowerCase().includes(keyword)) score += 2;
          if (faq.answer.toLowerCase().includes(keyword)) score += 1;
          return score;
        }, 0)
      }))
      .sort((a, b) => b.score - a.score || b.createdAt - a.createdAt);
  }, []);

  const debouncedSearch = useCallback(
    debounce((searchTerm, category, faqs) => {
      const filtered = searchFAQs(searchTerm, category, faqs);
      setFilteredFAQs(filtered);
    }, 300),
    [searchFAQs]
  );

  useEffect(() => {
    debouncedSearch(searchTerm, category, faqs);
  }, [debouncedSearch, searchTerm, category, faqs]);

  const handleAddFAQ = () => {
    setCurrentFAQ({ question: '', answer: '', category: '' });
    setDialogOpen(true);
  };

  const handleEditFAQ = (id) => {
    console.log("Editing FAQ with ID:", id);
    const faqToEdit = faqs.find(faq => faq.id === id);
    setCurrentFAQ(faqToEdit);
    setDialogOpen(true);
  };

  const handleDeleteFAQ = (id) => {
    console.log("Deleting FAQ with ID:", id); 
    setFaqs(faqs.filter(faq => faq.id !== id));
  };

  const handleSaveFAQ = () => {
    if (!currentFAQ.question.trim()) {
      alert("Question cannot be empty");
      return;
    }
    console.log("Saving FAQ with ID:", currentFAQ.id); 
    if (currentFAQ.id) {
      setFaqs(faqs.map(f => f.id === currentFAQ.id ? {...currentFAQ, createdAt: f.createdAt} : f));
    } else {
      setFaqs([...faqs, { ...currentFAQ, id: Date.now(), createdAt: new Date() }]);
    }
    setDialogOpen(false);
  };

  const handleToggleExpand = (id) => {
    setFaqs(faqs.map(faq => 
      faq.id === id ? { ...faq, expanded: !faq.expanded } : faq
    ));
  };

  // Calculate pagination
  const indexOfLastItem = page * itemsPerPage;
  const indexOfFirstItem = indexOfLastItem - itemsPerPage;
  const currentItems = filteredFAQs.slice(indexOfFirstItem, indexOfLastItem);

  const handleChangePage = (event, value) => {
    setPage(value);
  };

  return (
    <Container>
      <Typography variant="h4" gutterBottom>FAQ Management</Typography>
      <Box display="flex" justifyContent="space-between" mb={2}>
        <TextField
          label="Search FAQs"
          variant="outlined"
          value={searchTerm}
          onChange={(e) => setSearchTerm(e.target.value)}
          style={{ width: '60%' }}
        />
        <Select
          value={category}
          onChange={(e) => setCategory(e.target.value)}
          variant="outlined"
          style={{ width: '35%' }}
        >
          {categories.map((cat) => (
            <MenuItem key={cat} value={cat}>{cat}</MenuItem>
          ))}
        </Select>
      </Box>
      <Button
        variant="contained"
        color="primary"
        startIcon={<AddIcon />}
        onClick={handleAddFAQ}
        style={{ marginBottom: '20px' }}
      >
        ADD NEW FAQ
      </Button>
      <List>
        {filteredFAQs.length > 0 ? (
          currentItems.map((faq, index) => (
            <React.Fragment key={faq.id}>
              <ListItem style={{ backgroundColor: '#2196f3', color: 'white', marginBottom: '10px' }}>
                <ListItemText 
                  primary={`${indexOfFirstItem + index + 1}. ${faq.question}`} 
                  secondary={`Created: ${faq.createdAt.toLocaleDateString()}`}
                />
                <ListItemSecondaryAction>
                  <IconButton edge="end" aria-label="edit" onClick={() => handleEditFAQ(faq.id)}>
                    <EditIcon />
                  </IconButton>
                  <IconButton edge="end" aria-label="delete" onClick={() => handleDeleteFAQ(faq.id)}>
                    <DeleteIcon />
                  </IconButton>
                  <IconButton edge="end" aria-label="expand" onClick={() => handleToggleExpand(faq.id)}>
                    {faq.expanded ? <ExpandLessIcon /> : <ExpandMoreIcon />}
                  </IconButton>
                </ListItemSecondaryAction>
              </ListItem>
              <Collapse in={faq.expanded} timeout="auto" unmountOnExit>
                <ListItem style={{ paddingLeft: '32px' }}>
                  <ListItemText primary={faq.answer} secondary={`Category: ${faq.category}`} />
                </ListItem>
              </Collapse>
            </React.Fragment>
          ))
        ) : (
          <Typography variant="body1" align="center">
            No FAQs found matching your search criteria.
          </Typography>
        )}
      </List>
      {filteredFAQs.length > 0 && (
        <Box display="flex" justifyContent="center" mt={2}>
          <Pagination 
            count={Math.ceil(filteredFAQs.length / itemsPerPage)} 
            page={page} 
            onChange={handleChangePage} 
            color="primary" 
          />
        </Box>
      )}
      <FAQDialog
        open={dialogOpen}
        onClose={() => setDialogOpen(false)}
        currentFAQ={currentFAQ}
        setCurrentFAQ={setCurrentFAQ}
        onSave={handleSaveFAQ}
        categories={categories.filter(cat => cat !== 'All Categories')}
      />
    </Container>
  );
};

export default FAQManagement;