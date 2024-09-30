// src/components/CourseList.js
import React from 'react';
import { Grid,Box,Typography } from '@mui/material';
import CourseCard from '../CourseCard/CourseCard';

const courses = [
  {
    title: 'Kiến Thức Nền Tảng',
    description: 'Kiến thức nhập môn IT',
image: 'https://ictacademy.com.ng/wp-content/uploads/2020/02/358-3588175_ict-images-png-transparent-background-information-technology-logo.png',
    students: '130,185',
    lessons: '9',
    duration: '3h12p'
  },
  {
    title: 'Lập trình C++ cơ bản, nâng cao',
    description: 'Từ cơ bản đến nâng cao',
image: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQiFyEQ9FxotJhVjnyqErZ7DCjQlUmkDYO2Bw&s',
    students: '29,297',
    lessons: '55',
    duration: '10h18p'
  },
  {
    title: 'HTML, CSS từ zero đến hero',
    description: 'HTML CSS từ Zero đến Hero',
    image: 'https://letdiv.com/wp-content/uploads/2024/04/khoa-hoc-html-css.jpg',
    students: '200,431',
    lessons: '117',
    duration: '29h5p'
  },
  {
    title: 'Responsive @web design',
    description: 'Responsive Với Grid System',
    image: 'https://tailwindcss.com/api/og?path=/docs/responsive-design',
    students: '45,123',
    lessons: '34',
    duration: '6h31p'
  },
  {
    title: 'JavaScript (Cơ bản)',
    description: 'Lập Trình JavaScript Cơ Bản',
    image: 'https://upload.wikimedia.org/wikipedia/commons/6/6a/JavaScript-logo.png',
    students: '139,227',
    lessons: '112',
    duration: '24h15p'
  },
  {
    title: 'JavaScript (Nâng cao)',
    description: 'Lập Trình JavaScript Nâng Cao',
    image: 'https://global.discourse-cdn.com/sitepoint/original/3X/b/5/b59a78e2ed76c705f3c0dcb300f3f222aefdcd99.png',
    students: '38,306',
    lessons: '19',
    duration: '8h41p'
  },
  {
    title: 'WSL Ubuntu',
    description: 'Làm việc với Terminal & Ubuntu',
    image: 'https://scottiestech.info/wp-content/uploads/2022/11/WSL_Ubuntu_do-release-upgrade_2.jpg',
    students: '18,847',
    lessons: '28',
    duration: '4h59p'
  },
  {
    title: 'React JS',
    description: 'Xây Dựng Website với ReactJS',
    image: 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRlAsNnw9xNv8jwWcYfwiK_oLTfyybkvXr8cw&s',
    students: '68,733',
    lessons: '112',
    duration: '27h32p'
  },
  {
    title: 'Node & ExpressJS',
    description: 'Node & ExpressJS',
image: 'https://upload.wikimedia.org/wikipedia/commons/thumb/7/7e/Node.js_logo_2015.svg/2560px-Node.js_logo_2015.svg.png',
    students: '44,136',
    lessons: '36',
    duration: '12h8p'
  },
  {
    title: 'App "Đừng Chạm Tay Lên Mặt"',
    description: 'Ứng Dụng "Đừng Chạm Tay Lên Mặt"',
    image: 'https://cdn.tgdd.vn/Files/2023/01/08/1501551/face-id-iphone-la-gi-6.jpg',
    students: '10,136',
    lessons: '13',
    duration: '1h34p'
  },
];

const CourseList = () => {
  return (
    <Box sx={{ p: 1 }}>
      {/* Thêm tiêu đề "Course Available" */}
      <Typography variant="h4" component="h2" gutterBottom>
        Courses Available
      </Typography>
      
      {/* Danh sách các thẻ khóa học */}
      <Grid container spacing={1}>
        {courses.map((course, index) => (
          <Grid
          item
          xs={12}
          sm={6}
          md={2.4}
          key={index}
          sx={{ margin: 'auto' }} // Giảm margin giữa các thẻ xuống còn 4px
        >
            <CourseCard {...course} />
          </Grid>
        ))}
      </Grid>
    </Box>
  );
};
export default CourseList;