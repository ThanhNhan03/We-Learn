import React, { useState, useEffect, useCallback } from 'react';
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
  const [faqs, setFaqs] = useState([
    { id: 1, question: 'What is React?', answer: 'React is a JavaScript library for building user interfaces', category: 'Programming', expanded: false, createdAt: new Date('2023-01-01') },
    { id: 2, question: 'How do I style my React components?', answer: 'You can style React components using CSS, inline styles, or CSS-in-JS libraries.', category: 'Programming', expanded: false, createdAt: new Date('2023-01-15') },
    { id: 3, question: 'What is state in React?', answer: 'State is a JavaScript object that stores component data and determines how the component renders and behaves.', category: 'Programming', expanded: false, createdAt: new Date('2023-02-01') },
    { id: 4, question: 'How do I handle forms in React?', answer: 'You can handle forms in React by using controlled components and managing form state with hooks like useState.', category: 'Programming', expanded: false, createdAt: new Date('2023-02-15') },
    { id: 5, question: 'What are the principles of responsive design?', answer: 'Responsive design principles include fluid grids, flexible images, and media queries to create layouts that adapt to different screen sizes.', category: 'Design', expanded: false, createdAt: new Date('2023-03-01') },
  ]);
  const [dialogOpen, setDialogOpen] = useState(false);
  const [currentFAQ, setCurrentFAQ] = useState({ question: '', answer: '', category: '' });
  const [filteredFAQs, setFilteredFAQs] = useState([]); // Initialize as empty array
  const [page, setPage] = useState(1);
  const [itemsPerPage] = useState(5);

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
    // Remove the condition to clear filtered results
    debouncedSearch(searchTerm, category, faqs);
  }, [debouncedSearch, searchTerm, category, faqs]);

  const handleAddFAQ = () => {
    setCurrentFAQ({ question: '', answer: '', category: '' });
    setDialogOpen(true);
  };

  const handleEditFAQ = (id) => {
    const faqToEdit = faqs.find(faq => faq.id === id);
    setCurrentFAQ(faqToEdit);
    setDialogOpen(true);
  };

  const handleDeleteFAQ = (id) => {
    setFaqs(faqs.filter(faq => faq.id !== id));
  };

  const handleSaveFAQ = () => {
    if (!currentFAQ.question.trim()) {
      alert("Question cannot be empty");
      return;
    }
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

  const categories = [
    'All Categories',
    'Programming',
    'Design',
    'Database',
    'Networking',
    'Security',
    'Cloud Computing',
    'Machine Learning',
    'Web Development',
    'Mobile Development',
    'DevOps',
    'Artificial Intelligence',
    'Data Science',
    'Blockchain',
    'Internet of Things (IoT)',
    'Others'  // Added "Others" category
  ];

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