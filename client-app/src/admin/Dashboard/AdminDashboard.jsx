import React, { useState, useEffect } from 'react';
import AdminAppBar from './components/AdminAppBar.jsx';
import AdminDrawer from './components/AdminDrawer.jsx';
import HomeView from './components/HomeView.jsx';
import UserTable from './components/UserTable.jsx';
import NewsTable from './components/NewsTable.jsx';
import CreateAccountDialog from './components/CreateAccountDialog.jsx';
import EducatorTable from './components/EducatorTable.jsx'; // Import EducatorTable component
import { Toolbar } from '@mui/material';

const AdminDashboard = () => {
  const [darkMode, setDarkMode] = useState(false);
  const [view, setView] = useState('home');
  const [openDialog, setOpenDialog] = useState(false);
  const [formData, setFormData] = useState({
    firstName: '',
    lastName: '',
    email: '',
    birthday: '',
    phoneNumber: '',
    image: null,
    password: '',
    confirmPassword: '',
    role: '',
    gender: ''
  });
  const [users, setUsers] = useState([]); // Empty array for users
  const [news, setNews] = useState([]); // Empty array for news
  const [educators, setEducators] = useState([]); // Empty array for educators

  // Simulate fetching users from a temporary database
  const fetchUsers = () => {
    // Assuming we have a temporary database or a mock API
    const tempUsers = [
      { id: 1, firstName: 'John', lastName: 'Doe', email: 'john.doe@example.com' },
      { id: 2, firstName: 'Jane', lastName: 'Doe', email: 'jane.doe@example.com' },
      // Add more users as needed
    ];
    setUsers(tempUsers);
  };

  // Simulate fetching news from a temporary database
  const fetchNews = () => {
    // Assuming we have a temporary database or a mock API
    const tempNews = [
      { id: 1, title: 'News Title 1', content: 'News Content 1', author: 'Author 1', date: '2022-01-01' },
      { id: 2, title: 'News Title 2', content: 'News Content 2', author: 'Author 2', date: '2022-02-01' },
      // Add more news as needed
    ];
    setNews(tempNews);
  };

  // Simulate fetching educators from a temporary database
  const fetchEducators = () => {
    // Assuming we have a temporary database or a mock API
    const tempEducators = [
      { id: 1, name: "Nguyễn Văn A", email: "educatorA@example.com", phone: "123456789", gender: "Male", status: true, role: "Teacher" },
      { id: 2, name: "Trần Thị B", email: "educatorB@example.com", phone: "987654321", gender: "Female", status: false, role: "Assistant" },
      { id: 3, name: "Lê Văn C", email: "educatorC@example.com", phone: "456789123", gender: "Male", status: true, role: "Professor" },
      // Add more educators as needed
    ];
    setEducators(tempEducators);
  };

  useEffect(() => {
    fetchUsers();
    fetchNews();
    fetchEducators(); // Call fetchEducators function
  }, []);

  const handleThemeChange = () => {
    setDarkMode(!darkMode);
  };

  const handleDialogOpen = () => {
    setOpenDialog(true);
  };

  const handleDialogClose = () => {
    setOpenDialog(false);
  };

  const handleChange = (e) => {
    const { name, value } = e.target;
    setFormData({
      ...formData,
      [name]: value
    });
  };

  const handleFileChange = (e) => {
    setFormData({
      ...formData,
      image: e.target.files[0]
    });
  };

  const handleSubmit = () => {
    // Simulate creating a new user with form data
    // Assuming we have a temporary database or a mock API
    const newUser = {
      id: users.length + 1, // Assuming we want to simulate a new user with an incremented ID
      ...formData
    };
    setUsers([...users, newUser]);
    console.log('User created:', newUser);

    // Close the dialog after submission
    handleDialogClose();
  };

  const handleEditNews = (item) => {
    // Handle edit news logic (to be implemented)
    console.log('Edit news:', item);
  };

  const handleDeleteNews = (item) => {
    // Simulate deleting a news item
    // Assuming we have a temporary database or a mock API
    const updatedNews = news.filter(n => n.id !== item.id);
    setNews(updatedNews);
    console.log('News deleted:', item.id);
  };

  return (
    <div style={{ display: 'flex', backgroundColor: darkMode ? '#333' : '#fff', color: darkMode ? '#000' : '#000', minHeight: '100vh' }}>
      <AdminAppBar darkMode={darkMode} handleThemeChange={handleThemeChange} />
      <AdminDrawer darkMode={darkMode} setView={setView} />
      <main style={{ flexGrow: 1, padding: '24px' }}>
        <Toolbar />
        {view === 'home' && <HomeView users={users} setView={setView} handleDialogOpen={handleDialogOpen} />}
        {view === 'users' && <UserTable data={users} darkMode={darkMode} />}
        {view === 'news' && <NewsTable data={news} darkMode={darkMode} handleEditNews={handleEditNews} handleDeleteNews={handleDeleteNews} />}
        {view === 'educators' && <EducatorTable data={educators} darkMode={darkMode} handleViewEducator={() => {}} handleToggleEducatorAccount={() => {}} />} {/* Added EducatorTable component */}
      </main>
      <CreateAccountDialog
        open={openDialog}
        handleDialogClose={handleDialogClose}
        formData={formData}
        handleChange={handleChange}
        handleFileChange={handleFileChange}
        handleSubmit={handleSubmit}
      />
    </div>
  );
};

export default AdminDashboard;
