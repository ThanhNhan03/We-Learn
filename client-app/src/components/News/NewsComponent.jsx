import React, { useState, useEffect } from 'react';
import api from '../../api/AxiosAPI';
import {
  Dialog,
  DialogContent,
  IconButton,
  Typography,
  Card,
  CardContent,
  Box,
  Divider,
  CircularProgress
} from '@mui/material';
import InfiniteScroll from 'react-infinite-scroll-component';
import { styled } from '@mui/material/styles';

const StyledDialogContent = styled(DialogContent)(({ theme }) => ({
  padding: theme.spacing(4),
  backgroundColor: '#f5f5f5',
  position: 'relative',
  height: '85vh',
  overflow: 'hidden',

  // Customize scrollbar
  '& ::-webkit-scrollbar': {
    width: '6px',
  },
  '& ::-webkit-scrollbar-track': {
    background: '#e0e0e0',
  },
  '& ::-webkit-scrollbar-thumb': {
    background: '#bdbdbd',
    borderRadius: '3px',
  },
  '& ::-webkit-scrollbar-thumb:hover': {
    background: '#9e9e9e',
  },
}));

const NewsCard = styled(Card)(({ theme }) => ({
  transition: 'transform 0.3s ease-in-out, box-shadow 0.3s ease-in-out',
  '&:hover': {
    transform: 'translateY(-5px)',
    boxShadow: theme.shadows[4],
  },
}));

const NewsComponent = ({ open, onClose }) => {
  const [news, setNews] = useState([]);
  const [page, setPage] = useState(1);
  const [hasMore, setHasMore] = useState(true);

  useEffect(() => {
    if (open) {
      fetchNews();
    }
  }, [open]);

  const fetchNews = async () => {
    try {
      const response = await api.get(`/News?pageNumber=${page}&pageSize=5`);
      const newNews = response.data.data.items;
      setNews(prevNews => [...prevNews, ...newNews]);
      setPage(prevPage => prevPage + 1);
      setHasMore(newNews.length === 5);
    } catch (error) {
      console.error('Error loading news:', error);
    }
  };

  return (
    <Dialog
      open={open}
      onClose={onClose}
      maxWidth="md"
      fullWidth
      PaperProps={{
        style: { borderRadius: 16 },
      }}
    >
      <StyledDialogContent>
        <IconButton
          aria-label="close"
          onClick={onClose}
          sx={{
            position: 'absolute',
            right: 16,
            top: 16,
            color: 'grey.500',
            bgcolor: 'white',
            '&:hover': {
              bgcolor: 'grey.100',
            },
            zIndex: 1,
          }}
        >
          {/* Add close icon here */}
        </IconButton>
        <Typography variant="h4" sx={{ mb: 3, fontWeight: 'bold', textAlign: 'center' }}>
          Latest News
        </Typography>
        <InfiniteScroll
          dataLength={news.length}
          next={fetchNews}
          hasMore={hasMore}
          height="calc(85vh - 100px)"
          loader={<CircularProgress sx={{ display: 'block', margin: '20px auto' }} />}
          style={{ overflow: 'auto' }}
        >
          {news.map((item, index) => (
            <React.Fragment key={item.id}>
              <NewsCard sx={{ mb: 3, bgcolor: 'white' }}>
                <CardContent>
                  <Typography variant="h5" sx={{ mb: 2, fontWeight: 'bold', color: '#1976d2' }}>
                    {item.title}
                  </Typography>
                  <Typography variant="body1" sx={{ mb: 2, color: '#424242' }}>
                    {item.content}
                  </Typography>
                  {item.linkUrl && (
                    <Box display="flex" alignItems="center" mb={1}>
                      <Box
                        component="span"
                        sx={{
                          display: 'inline-block',
                          width: 12,
                          height: 12,
                          bgcolor: '#4caf50',
                          borderRadius: '50%',
                          mr: 1,
                        }}
                      />
                      <Typography variant="body2" color="primary" component="a" href={item.linkUrl} target="_blank" rel="noopener noreferrer">
                        {item.linkUrl}
                      </Typography>
                    </Box>
                  )}
                  <Typography variant="body2" color="text.secondary" sx={{ fontStyle: 'italic' }}>
                    Posted by {item.adminName} • {new Date(item.createdAt).toLocaleDateString()}
                  </Typography>
                </CardContent>
              </NewsCard>
              {index < news.length - 1 && <Divider sx={{ mb: 3 }} />}
            </React.Fragment>
          ))}
        </InfiniteScroll>
      </StyledDialogContent>
    </Dialog>
  );
};

export default NewsComponent;