import React from 'react';
import {
  Dialog,
  DialogContent,
  IconButton,
  Typography,
  Card,
  CardMedia,
  CardContent,
  Link,
  Box,
  Divider
} from '@mui/material';
import CloseIcon from '@mui/icons-material/Close';

const NewsComponent = ({ open, onClose }) => {
  const notifications = [
    {
      title: "Dự án cuối khóa HTML CSS Pro đang tăng tốc!",
      description: "Dự án cuối khóa khá \"hoành\" chỉ là HTML CSS mà công phu ghê lắm: multiple pages, dark/light mode, sử dụng Sass 7-1 pattern, responsive áp dụng 6 breakpoints, sử dụng Grid system, v.v.",
      imageUrl: "https://files.fullstack.edu.vn/f8-prod/public-images/650d9b3b1aa0f.png",
      linkText: "Tìm hiểu thêm về khóa học tại đây bạn nhé: https://fullstack.edu.vn/landing/htmlcss/",
      postedBy: "Son Dang",
      postedTime: "một năm trước"
    },
    {
      title: "Tại sao F8 bị DDoS lại không thể truy cập được?",
      description: "Ngày hôm qua F8 không truy cập được là do bị tấn công từ dịch vụ phân tán (DDoS). Rất mong các bạn thông cảm vì F8 có không truy cập được. Chúng mình sẽ tìm giải pháp để duy trì sự ổn định giúp các bạn có môi trường học tập tốt nhất có thể ❤️",
      imageUrl: "https://files.fullstack.edu.vn/f8-prod/public-images/6528f2d285a52.png",
      linkText: "",
      postedBy: "Son Dang",
      postedTime: "một năm trước"
    },
    {
        title: "Nhận ebook giao tiếp tiếng Anh trị giá 200k!",
        description: "Với mong muốn cải tiến sản phẩm và phục vụ các học viên tốt hơn, phòng sản phẩm The Coach đang rất cần những ý kiến đóng góp của các bạn.",
        imageUrl: "https://files.fullstack.edu.vn/f8-prod/public-images/651412ac8ab28.png",
        linkText: "✅ Tham gia khảo sát qua Link: https://forms.gle/B7L9BQ43umWCuUBm9",
        postedBy: "Son Dang",
        postedTime: "một năm trước"
      },
      {
        title: "#Ra mắt Dev Mode giúp học qua video hiệu quả hơn!",
        description: "Khi học qua video các bạn thường thực hành lại bằng VS Code, điều này cũng khá phiền nên nhiều khi chúng ta lười, không thèm thực hành nữa. Hiệu quả học tập bị giảm sút 😎:(",
        imageUrl: "https://files.fullstack.edu.vn/f8-prod/public-images/64f2ed13b300c.png",
        linkText: "Tim hieu them ve khoa hoc tai day ban nhe: https://fullstack.edu.vn/landing/htmlcss/",
        postedBy: "Son Dang",
        postedTime: "một năm trước"
      },  
    
  ];

  const handleImageClick = (linkText) => {
    if (linkText) {
      const url = linkText.split(': ')[1];
      window.open(url, '_blank');
    }
  };

  return (
    <Dialog
      open={open}
      onClose={onClose}
      maxWidth="md"
      fullWidth
    >
      <DialogContent sx={{ p: 3, bgcolor: 'white', position: 'relative' }}>
        <IconButton
          aria-label="close"
          onClick={onClose}
          sx={{
            position: 'absolute',
            right: 8,
            top: 8,
            color: 'grey.500',
          }}
        >
          <CloseIcon />
        </IconButton>
        {notifications.map((notification, index) => (
          <React.Fragment key={index}>
            <Card sx={{ boxShadow: 'none', mb: 3 }}>
              <Typography variant="h5" sx={{ mb: 2, fontWeight: 'bold' }}>
                {notification.title}
              </Typography>
              <Typography variant="subtitle1" sx={{ mb: 2 }}>
                {notification.description}
              </Typography>
              <CardMedia
                component="img"
                image={notification.imageUrl}
                alt={notification.title}
                sx={{ width: '100%', height: 'auto', cursor: notification.linkText ? 'pointer' : 'default', mb: 2 }}
                onClick={() => handleImageClick(notification.linkText)}
              />
              <CardContent sx={{ p: 0 }}>
                {notification.linkText && (
                  <Box display="flex" alignItems="center" mb={1}>
                    <Box
                      component="span"
                      sx={{
                        display: 'inline-block',
                        width: 20,
                        height: 20,
                        bgcolor: 'green',
                        borderRadius: '70%',
                        mr: 1,
                      }}
                    />
                    <Typography variant="body2">
                      {notification.linkText}
                    </Typography>
                  </Box>
                )}
                <Typography variant="body2" color="text.secondary">
                  Đăng bởi {notification.postedBy} • {notification.postedTime}
                </Typography>
              </CardContent>
            </Card>
            {index < notifications.length - 1 && <Divider sx={{ mb: 3 }} />}
          </React.Fragment>
        ))}
      </DialogContent>
    </Dialog>
  );
};

export default NewsComponent;