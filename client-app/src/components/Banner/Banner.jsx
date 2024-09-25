import React from "react";
import BannerPng from "../../assets/education.png";
import { GrUserExpert } from "react-icons/gr";
import { MdOutlineAccessTime } from "react-icons/md";
import { FaBookReader } from "react-icons/fa";
import { FadeUp } from "../Hero/Hero";
import { motion } from "framer-motion";
import { Container, Grid, Box, Typography, Paper } from '@mui/material';

const Banner = () => {
  return (
    <section>
      <Container sx={{ py: { xs: 14, md: 24 } }}>
        <Grid container spacing={8}>
          {/* Banner Image */}
          <Grid item xs={12} md={6} display="flex" justifyContent="center" alignItems="center">
            <motion.img
              initial={{ opacity: 0, x: -50 }}
              whileInView={{ opacity: 1, x: 0 }}
              viewport={{ once: true }}
              transition={{ duration: 0.5, ease: "easeInOut" }}
              src={BannerPng}
              alt=""
              style={{ width: '350px', maxWidth: '450px', objectFit: 'cover', boxShadow: '0px 4px 6px rgba(0, 0, 0, 0.1)' }}
            />
          </Grid>
          {/* Banner Text */}
          <Grid item xs={12} md={6} display="flex" flexDirection="column" justifyContent="center">
            <Box textAlign={{ xs: 'center', md: 'left' }} mb={3}>
              <motion.h1
                initial={{ opacity: 0, scale: 0.5 }}
                whileInView={{ opacity: 1, scale: 1 }}
                viewport={{ once: true }}
                transition={{ duration: 0.5 }}
                style={{ fontSize: '2rem', fontWeight: 'bold', lineHeight: '1.2' }}
              >
                The World's Leading Online learning Platform
              </motion.h1>
            </Box>
            <Box display="flex" flexDirection="column" gap={2}>
              <motion.div
                variants={FadeUp(0.2)}
                initial="initial"
                whileInView={"animate"}
                viewport={{ once: true }}
              >
                <Paper elevation={3} sx={{ p: 3, display: 'flex', alignItems: 'center', gap: 2, bgcolor: '#f4f4f4', '&:hover': { bgcolor: 'white', boxShadow: 6 } }}>
                  <FaBookReader style={{ fontSize: '1.5rem' }} />
                  <Typography variant="body1">10,000+ Courses</Typography>
                </Paper>
              </motion.div>
              <motion.div
                variants={FadeUp(0.4)}
                initial="initial"
                whileInView={"animate"}
                viewport={{ once: true }}
              >
                <Paper elevation={3} sx={{ p: 3, display: 'flex', alignItems: 'center', gap: 2, bgcolor: '#f4f4f4', '&:hover': { bgcolor: 'white', boxShadow: 6 } }}>
                  <GrUserExpert style={{ fontSize: '1.5rem' }} />
                  <Typography variant="body1">Expert Instruction</Typography>
                </Paper>
              </motion.div>
              <motion.div
                variants={FadeUp(0.6)}
                initial="initial"
                whileInView={"animate"}
                viewport={{ once: true }}
              >
                <Paper elevation={3} sx={{ p: 3, display: 'flex', alignItems: 'center', gap: 2, bgcolor: '#f4f4f4', '&:hover': { bgcolor: 'white', boxShadow: 6 } }}>
                  <MdOutlineAccessTime style={{ fontSize: '1.5rem' }} />
                  <Typography variant="body1">Lifetime Access</Typography>
                </Paper>
              </motion.div>
            </Box>
          </Grid>
        </Grid>
      </Container>
    </section>
  );
};

export default Banner;
