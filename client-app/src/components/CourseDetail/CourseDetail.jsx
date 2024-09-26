// src/components/CourseDetail/CourseDetail.js
import React from 'react';
import { useParams, useLocation } from 'react-router-dom';
import { Container, Typography, Box, Card, CardContent, CardMedia, Button, Grid, Paper } from '@mui/material';
import { AccessTime, Star, Info } from '@mui/icons-material';
import Navbar from '../Navbar/Navbar'; // Adjust the path to Navbar component
import Footer from '../Footer/Footer'; // Adjust the path to Footer component

const CourseDetail = () => {
  const { title } = useParams();
  const { state } = useLocation(); // Retrieve state passed via Link
  const decodedTitle = decodeURIComponent(title);

  if (!state) {
    // If state is not available, display an error or fetch the data based on URL parameter
    return (
      <Container sx={{ mt: 5 }}>
        <Typography variant="h5">Course not found</Typography>
      </Container>
    );
  }

  const { description, image, instructor, duration, rating, reviews } = state; // Destructure the passed state

  return (
    <>
      {/* Add Navbar at the top */}
      <Navbar />

      {/* Main content of the Course Detail */}
      <Container sx={{ mt: 5, minHeight: '70vh' }}> {/* minHeight ensures content has enough space */}
        {/* Main course header with image */}
        <Card sx={{ mb: 3 }}>
          <CardMedia
            component="img"
            height="300"
            image={image} // Use the image from the state
            alt={decodedTitle}
            sx={{ objectFit: 'cover' }}
          />
          <CardContent>
            <Typography variant="h4" component="h1" gutterBottom>
              {decodedTitle}
            </Typography>
            <Typography variant="body1" color="text.secondary" paragraph>
              {description}
            </Typography>
            <Grid container spacing={2}>
              <Grid item>
                <Info fontSize="small" sx={{ verticalAlign: 'middle', mr: 0.5 }} />
                <Typography variant="body2" display="inline">
                  Instructor: {instructor}
                </Typography>
              </Grid>
              <Grid item>
                <AccessTime fontSize="small" sx={{ verticalAlign: 'middle', mr: 0.5 }} />
                <Typography variant="body2" display="inline">
                  Duration: {duration}
                </Typography>
              </Grid>
              <Grid item>
                <Star fontSize="small" sx={{ verticalAlign: 'middle', mr: 0.5 }} />
                <Typography variant="body2" display="inline">
                  Rating: {rating} ({reviews} reviews)
                </Typography>
              </Grid>
            </Grid>
          </CardContent>
        </Card>

        {/* Course content section */}
        <Paper elevation={3} sx={{ p: 3, mb: 3 }}>
          <Typography variant="h5" component="h2" gutterBottom>
            What You Will Learn
          </Typography>
          <Typography variant="body1" paragraph>
            - Understanding the basics of {decodedTitle}. <br />
            - Applying advanced concepts in real-world scenarios. <br />
            - Building practical projects to solidify your knowledge. <br />
            - And much more!
          </Typography>
        </Paper>

        {/* Call-to-action */}
        <Box textAlign="center" sx={{ mt: 3 }}>
          <Button variant="contained" color="primary" size="large" sx={{ mr: 2 }}>
            Enroll Now
          </Button>
          <Button variant="outlined" color="secondary" size="large">
            Share
          </Button>
        </Box>
      </Container>

      {/* Add Footer at the bottom */}
      <Footer />
    </>
  );
};

export default CourseDetail;