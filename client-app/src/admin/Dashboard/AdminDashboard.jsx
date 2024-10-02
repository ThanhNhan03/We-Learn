import React, { useState, useEffect, lazy, Suspense } from 'react';
import { useLocation, useNavigate } from 'react-router-dom';
import AdminAppBar from './components/AdminAppBar.jsx';
import AdminDrawer from './components/AdminDrawer.jsx';
import HomeView from './components/HomeView.jsx';
import NewsTable from './components/NewsTable.jsx';
import CreateAccountDialog from './components/CreateAccountDialog.jsx';
import EducatorTable from './components/EducatorTable.jsx';
import { Toolbar, CircularProgress } from '@mui/material';
import CourseTable from './components/CourseTable.jsx';
import AdminCourseDetail from './components/AdminCourseDetail.jsx';
import AdminLectureDetail from './components/AdminLectureDetail.jsx';
import CreateLectureDialog from './components/CreateandUpdateLectureDialog.jsx';


const UserTable = lazy(() => import('./components/UserTable.jsx'));

const AdminDashboard = () => {
  const location = useLocation();
  const navigate = useNavigate();
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
  const [courses, setCourses] = useState([]); // Empty array for courses
  const [selectedCourse, setSelectedCourse] = useState(null);
  const [isCreateLectureDialogOpen, setIsCreateLectureDialogOpen] = useState(false);
  const [selectedLecture, setSelectedLecture] = useState(null);


 

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

  const handleCourseSelect = (course) => {
    setSelectedCourse(course);
  };

  const handleBackToCourseList = () => {
    setSelectedCourse(null);
  };

  const handleOpenCreateLectureDialog = () => {
    setIsCreateLectureDialogOpen(true);
  };

  const handleCloseCreateLectureDialog = () => {
    setIsCreateLectureDialogOpen(false);
  };

  const handleCreateLecture = (lectureData) => {
    // Xử lý logic tạo bài giảng mới ở đây
    console.log('New lecture data:', lectureData);
    // Sau khi tạo xong, đóng dialog
    setIsCreateLectureDialogOpen(false);
  };

  // Function to handle selecting a lecture for detail view
  const handleSelectLecture = (lecture) => {
    setSelectedLecture(lecture);
    setView('lectureDetail');
  };

  // Function to handle back navigation
  const handleBack = () => {
    setSelectedLecture(null);
    setView('courseDetail'); // Assuming you want to go back to the course detail
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
        {view === 'courseDetail' && <AdminCourseDetail />}
        {view === 'lectureDetail' && selectedLecture && (
          <AdminLectureDetail lecture={selectedLecture} onClose={handleBack} />
        )}
      </main>
      <CreateAccountDialog
        open={openDialog}
        handleDialogClose={handleDialogClose}
        formData={formData}
        handleChange={handleChange}
        handleFileChange={handleFileChange}
        handleSubmit={handleSubmit}
      />
      <CreateLectureDialog
        open={isCreateLectureDialogOpen}
        onClose={handleCloseCreateLectureDialog}
        onCreateLecture={handleCreateLecture}
      />
    </div>
  );
};

export default AdminDashboard;
