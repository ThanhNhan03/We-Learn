import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { TextField, Button, RadioGroup, FormControlLabel, Radio, FormControl, FormLabel } from '@mui/material';

const AdminAdd = () => {
  const [formData, setFormData] = useState({
    firstName: '',
    lastName: '',
    email: '',
    birthday: '',
    phone: '',
    role: 'Admin',
    gender: 'Male',
    password: '',
    confirmPassword: '',
  });

  const navigate = useNavigate();

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({ ...formData, [name]: value });
  };

  const handleSubmit = (e) => {
    e.preventDefault();
    // Thêm logic để xử lý việc tạo user mới
    console.log(formData);
    navigate('/');
  };

  return (
    <form onSubmit={handleSubmit} style={{ display: 'flex', flexDirection: 'column', gap: '16px', padding: '24px' }}>
      <TextField label="First Name" name="firstName" value={formData.firstName} onChange={handleChange} required />
      <TextField label="Last Name" name="lastName" value={formData.lastName} onChange={handleChange} required />
      <TextField label="Email" name="email" value={formData.email} onChange={handleChange} required />
      <TextField label="Birthday" name="birthday" type="date" value={formData.birthday} onChange={handleChange} InputLabelProps={{ shrink: true }} required />
      <TextField label="Telephone Number" name="phone" value={formData.phone} onChange={handleChange} required />
      <FormControl component="fieldset">
        <FormLabel component="legend">Role</FormLabel>
        <RadioGroup row name="role" value={formData.role} onChange={handleChange}>
          <FormControlLabel value="Admin" control={<Radio />} label="Admin" />
          <FormControlLabel value="Teacher" control={<Radio />} label="Teacher" />
        </RadioGroup>
      </FormControl>
      <FormControl component="fieldset">
        <FormLabel component="legend">Gender</FormLabel>
        <RadioGroup row name="gender" value={formData.gender} onChange={handleChange}>
          <FormControlLabel value="Male" control={<Radio />} label="Male" />
          <FormControlLabel value="Female" control={<Radio />} label="Female" />
          <FormControlLabel value="Other" control={<Radio />} label="Other" />
        </RadioGroup>
      </FormControl>
      <TextField label="Password" name="password" type="password" value={formData.password} onChange={handleChange} required />
      <TextField label="Confirm Password" name="confirmPassword" type="password" value={formData.confirmPassword} onChange={handleChange} required />
      <Button type="submit" variant="contained">Submit</Button>
      <Button variant="outlined" onClick={() => navigate('/')}>Cancel</Button>
    </form>
  );
};

export default AdminAdd;