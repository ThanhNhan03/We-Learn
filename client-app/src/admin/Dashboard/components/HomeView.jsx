import React from 'react';
import { Grid, Card, CardContent, Typography, Button } from '@mui/material';

const HomeView = ({ users, setView, handleDialogOpen }) => {
  return (
    <Grid container spacing={2}>
      <Grid item xs={6}>
        <Card onClick={() => setView('users')}>
          <CardContent>
            <Typography variant="h5">Users</Typography>
            <Typography variant="h6">{users.length}</Typography>
          </CardContent>
        </Card>
      </Grid>
      <Grid item xs={6}>
        <Card onClick={() => setView('educators')}>
          <CardContent>
            <Typography variant="h5">Educators</Typography>
            <Typography variant="h6">50</Typography>
          </CardContent>
        </Card>
      </Grid>
      <Grid item xs={12} style={{ display: 'flex', justifyContent: 'flex-end' }}>
        <Button variant="contained" onClick={handleDialogOpen}>
          Create Account
        </Button>
      </Grid>
    </Grid>
  );
};

export default HomeView;
