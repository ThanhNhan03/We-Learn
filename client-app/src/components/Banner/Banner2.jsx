import React from "react";
import BannerPng from "../../assets/banner.png";
import { motion } from "framer-motion";
import { Container, Grid, Box, Typography, Button } from '@mui/material';

const Banner2 = () => {
  return (
    <section>
      <Container sx={{ py: { xs: 14, md: 24 } }}>
        <Grid container spacing={8}>
          {/* Banner Text */}
          <Grid item xs={12} md={6} display="flex" flexDirection="column" justifyContent="center">
            <motion.div
              initial={{ opacity: 0, x: -50 }}
              whileInView={{ opacity: 1, x: 0 }}
              viewport={{ once: true }}
              transition={{ duration: 0.5, ease: "easeInOut" }}
            >
              <Box textAlign={{ xs: 'center', md: 'left' }} mb={3}>
                <Typography variant="h3" component="h1" fontWeight="bold" gutterBottom>
                  Join Our Community to Start your Journey
                </Typography>
                <Typography variant="body1" color="textSecondary" paragraph>
                  Lorem ipsum dolor sit amet consectetur adipisicing elit. Recusandae iusto minima ad ut id eos accusantium aut, aperiam quis incidunt!
                </Typography>
                <Button
                  variant="contained"
                  color="primary"
                  href="https://chat.whatsapp.com/FQSKgJ5f1eIAhlyF5sVym0"
                  sx={{ mt: 2 }}
                >
                  Join Now
                </Button>
              </Box>
            </motion.div>
          </Grid>
          {/* Banner Image */}
          <Grid item xs={12} md={6} display="flex" justifyContent="center" alignItems="center">
            <motion.img
              initial={{ opacity: 0, x: 50 }}
              whileInView={{ opacity: 1, x: 0 }}
              viewport={{ once: true }}
              transition={{ duration: 0.5, ease: "easeInOut" }}
              src={BannerPng}
              alt=""
              style={{ width: '350px', maxWidth: '450px', objectFit: 'cover', boxShadow: '0px 4px 6px rgba(0, 0, 0, 0.1)' }}
            />
          </Grid>
        </Grid>
      </Container>
    </section>
  );
};

export default Banner2;
