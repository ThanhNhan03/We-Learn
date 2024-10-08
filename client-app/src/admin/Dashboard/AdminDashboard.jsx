import React, { useState, lazy, Suspense } from 'react';
import { useLocation } from 'react-router-dom';
import AdminAppBar from './components/AdminAppBar.jsx';
import AdminDrawer from './components/AdminDrawer.jsx';
import HomeView from './components/HomeView.jsx';
import NewsTable from './components/NewsTable.jsx';
import CreateAccountDialog from './components/CreateAccountDialog.jsx';
import EducatorTable from './components/EducatorTable.jsx';
import { Toolbar, CircularProgress } from '@mui/material';
import CourseTable from './components/CourseTable.jsx';
import FAQManagement from './components/FAQManagement.jsx';

const UserTable = lazy(() => import('./components/UserTable.jsx'));

const AdminDashboard = () => {
  const location = useLocation();
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
  const [users, setUsers] = useState([]);
  const [news, setNews] = useState([]);
  const [educators, setEducators] = useState([]);
  const [courses, setCourses] = useState([]);

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
    const newUser = {
      id: users.length + 1,
      ...formData
    };
    setUsers([...users, newUser]);
    console.log('User created:', newUser);
    handleDialogClose();
  };

  const handleEditNews = (item) => {
    console.log('Edit news:', item);
  };

  const handleDeleteNews = (item) => {
    const updatedNews = news.filter(n => n.id !== item.id);
    setNews(updatedNews);
    console.log('News deleted:', item.id);
  };

  return (
    <div style={{ display: 'flex', backgroundColor: darkMode ? '#333' : '#fff', minHeight: '100vh' }}>
      <AdminAppBar darkMode={darkMode} handleThemeChange={handleThemeChange} />
      <AdminDrawer darkMode={darkMode} setView={setView} />
      <main style={{ flexGrow: 1, padding: '24px' }}>
        <Toolbar />
        {view === 'home' && <HomeView users={users} setView={setView} handleDialogOpen={handleDialogOpen} />}
        {view === 'users' && (
          <Suspense fallback={<CircularProgress />}>
            <UserTable data={users} darkMode={darkMode} />
          </Suspense>
        )}
        {view === 'news' && <NewsTable data={news} darkMode={darkMode} handleEditNews={handleEditNews} handleDeleteNews={handleDeleteNews} />}
        {view === 'educators' && <EducatorTable data={educators} darkMode={darkMode} handleViewEducator={() => {}} handleToggleEducatorAccount={() => {}} />}
        {view === 'courses' && <CourseTable data={courses} darkMode={darkMode} />}
        {view === 'faqs' && <FAQManagement />}
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
