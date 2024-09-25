import React from "react";
import { FaInstagram, FaWhatsapp, FaYoutube } from "react-icons/fa";
import { TbWorldWww } from "react-icons/tb";
import { motion } from "framer-motion";
import { Container, Grid, Box, Typography, TextField, Button, IconButton } from '@mui/material';

const Footer = () => {
  return (
    <footer style={{ padding: '56px 0', backgroundColor: '#f7f7f7' }}>
      <motion.div
        initial={{ opacity: 0, y: 50 }}
        whileInView={{ opacity: 1, y: 0 }}
      >
        <Container>
          <Grid container spacing={4}>
            {/* first section */}
            <Grid item xs={12} md={4}>
              <Box maxWidth={300}>
                <Typography variant="h5" fontWeight="bold">The Coding Journey</Typography>
                <Typography variant="body1" color="textSecondary">
                  TCJ is a platform dedicated to empowering aspiring developers.
                  From beginner tutorials to advanced programming concepts, we
                  provide a comprehensive learning experience designed to help you
                  master coding skills, build projects, and launch your tech career.
                </Typography>
              </Box>
            </Grid>
            {/* second section */}
            <Grid item xs={12} md={4}>
              <Grid container spacing={2}>
                <Grid item xs={6}>
                  <Box>
                    <Typography variant="h5" fontWeight="bold">Courses</Typography>
                    <Box>
                      <ul style={{ listStyle: 'none', padding: 0 }}>
                        <li style={{ marginBottom: '8px' }}>
                          <Typography variant="body1" className="cursor-pointer hover:text-secondary duration-200">
                            Web Development
                          </Typography>
                        </li>
                        <li style={{ marginBottom: '8px' }}>
                          <Typography variant="body1" className="cursor-pointer hover:text-secondary duration-200">
                            Software Development
                          </Typography>
                        </li>
                        <li style={{ marginBottom: '8px' }}>
                          <Typography variant="body1" className="cursor-pointer hover:text-secondary duration-200">
                            Apps Development
                          </Typography>
                        </li>
                        <li style={{ marginBottom: '8px' }}>
                          <Typography variant="body1" className="cursor-pointer hover:text-secondary duration-200">
                            E-learning
                          </Typography>
                        </li>
                      </ul>
                    </Box>
                  </Box>
                </Grid>
                <Grid item xs={6}>
                  <Box>
                    <Typography variant="h5" fontWeight="bold">Links</Typography>
                    <Box>
                      <ul style={{ listStyle: 'none', padding: 0 }}>
                        <li style={{ marginBottom: '8px' }}>
                          <Typography variant="body1" className="cursor-pointer hover:text-secondary duration-200">
                            Home
                          </Typography>
                        </li>
                        <li style={{ marginBottom: '8px' }}>
                          <Typography variant="body1" className="cursor-pointer hover:text-secondary duration-200">
                            Services
                          </Typography>
                        </li>
                        <li style={{ marginBottom: '8px' }}>
                          <Typography variant="body1" className="cursor-pointer hover:text-secondary duration-200">
                            About
                          </Typography>
                        </li>
                        <li style={{ marginBottom: '8px' }}>
                          <Typography variant="body1" className="cursor-pointer hover:text-secondary duration-200">
                            Contact
                          </Typography>
                        </li>
                      </ul>
                    </Box>
                  </Box>
                </Grid>
              </Grid>
            </Grid>
            {/* third section */}
            <Grid item xs={12} md={4}>
              <Box maxWidth={300}>
                <Typography variant="h5" fontWeight="bold">Get In Touch</Typography>
                <Box display="flex" alignItems="center" mt={2}>
                  <TextField
                    variant="outlined"
                    placeholder="Enter your email"
                    fullWidth
                    InputProps={{ style: { borderRadius: '4px 0 0 4px' } }}
                  />
                  <Button variant="contained" color="primary" style={{ borderRadius: '0 4px 4px 0' }}>
                    Go
                  </Button>
                </Box>
                {/* social icons */}
                <Box display="flex" mt={2}>
                  <IconButton href="https://chat.whatsapp.com/FQSKgJ5f1eIAhlyF5sVym0">
                    <FaWhatsapp className="cursor-pointer hover:text-primary hover:scale-105 duration-200" />
                  </IconButton>
                  <IconButton href="https://www.instagram.com/the.coding.journey/">
                    <FaInstagram className="cursor-pointer hover:text-primary hover:scale-105 duration-200" />
                  </IconButton>
                  <IconButton href="https://thecodingjourney.com/">
                    <TbWorldWww className="cursor-pointer hover:text-primary hover:scale-105 duration-200" />
                  </IconButton>
                  <IconButton href="https://www.youtube.com/@TheCodingJourney">
                    <FaYoutube className="cursor-pointer hover:text-primary hover:scale-105 duration-200" />
                  </IconButton>
                </Box>
              </Box>
            </Grid>
          </Grid>
        </Container>
      </motion.div>
    </footer>
  );
};

export default Footer;
