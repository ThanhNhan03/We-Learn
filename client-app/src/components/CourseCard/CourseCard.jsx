// src/components/CourseCard/CourseCard.js
import React from 'react';
import PropTypes from 'prop-types';
import { Link } from 'react-router-dom'; // Import Link from react-router-dom
import { Card, CardContent, CardMedia, Typography, Box, Stack } from '@mui/material';
import { Group, AccessTime, MenuBook } from '@mui/icons-material';

const CourseCard = ({ title, description, image, students, lessons, duration }) => {
  return (
    <Link
      to={`/course/${encodeURIComponent(title)}`} // Navigate to course detail page with encoded title
      state={{ title, description, image, students, lessons, duration }} // Pass course data through state
      style={{ textDecoration: 'none' }} // Remove underline from link
    >
      <Card
        sx={{
          maxWidth: 345,
          m: 1,
          transition: 'transform 0.3s ease-in-out, box-shadow 0.3s ease-in-out',
          '&:hover': {
            transform: 'scale(1.05)',
            boxShadow: '0 8px 16px rgba(0,0,0,0.2)',
          },
          cursor: 'pointer',
        }}
      >
        <CardMedia
          component="img"
          height="140"
          image={image}
          alt={title}
          sx={{ objectFit: 'cover' }}
        />
        <CardContent>
          <Typography gutterBottom variant="subtitle1" component="div" sx={{ fontSize: '1rem' }}>
            {title}
          </Typography>
          <Typography variant="body2" color="text.secondary" sx={{ fontSize: '0.875rem' }}>
            {description}
          </Typography>
          <Box sx={{ mt: 2 }}>
            <Stack direction="row" justifyContent="space-between" alignItems="center" spacing={1}>
              <Stack direction="row" alignItems="center" spacing={0.5}>
                <Group fontSize="small" />
                <Typography variant="caption" sx={{ fontSize: '0.75rem' }}>
                  {students}
                </Typography>
              </Stack>
              <Stack direction="row" alignItems="center" spacing={0.5}>
                <MenuBook fontSize="small" />
                <Typography variant="caption" sx={{ fontSize: '0.75rem' }}>
                  {lessons} lessons
                </Typography>
              </Stack>
              <Stack direction="row" alignItems="center" spacing={0.5}>
                <AccessTime fontSize="small" />
                <Typography variant="caption" sx={{ fontSize: '0.75rem' }}>
                  {duration}
                </Typography>
              </Stack>
            </Stack>
          </Box>
        </CardContent>
      </Card>
    </Link>
  );
};

CourseCard.propTypes = {
  title: PropTypes.string.isRequired,
  description: PropTypes.string,
  image: PropTypes.string.isRequired,
  students: PropTypes.string.isRequired,
  lessons: PropTypes.string.isRequired,
  duration: PropTypes.string.isRequired,
};

export default CourseCard;