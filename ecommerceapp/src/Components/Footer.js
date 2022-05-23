import React from "react";
import FacebookIcon from "@mui/icons-material/Facebook";
import TwitterIcon from "@mui/icons-material/Twitter";
import InstagramIcon from "@mui/icons-material/Instagram";
import { Box } from "@mui/system";
import { List, ListItem, Typography } from "@mui/material";
import LocationOnIcon from "@mui/icons-material/LocationOn";
import PhoneIcon from "@mui/icons-material/Phone";
import EmailIcon from "@mui/icons-material/Email";
import ArrowUpwardIcon from "@mui/icons-material/ArrowUpward";

function Footer() {
  const ListItemContainer = ({ children }) => (
    <ListItem
      sx={{
        width: "40%",
        p: 0,
        m: 0,
        mb: 2,
        cursor: "pointer",
      }}
    >
      {children}
    </ListItem>
  );

  const SocialIcon = ({ children, ...props }) => (
    <Box
      sx={{
        width: "40px",
        height: "40px",
        borderRadius: "50%",
        display: "flex",
        justifyContent: "center",
        alignItems: "center",
        marginRight: "20px",
        backgroundColor: "coral",
        color: "white",
        cursor: "pointer",
        marginRight: "20px",
        "&:hover": {
          transform: "scale(1.1)",
          transition: "all 0.3s ease-in-out",
          boxShadow: "0px 0px 10px rgba(0,0,0,0.2)",
        },
      }}
    >
      {children}
    </Box>
  );

  return (
    <Box // container
      sx={{
        display: "flex",
        marginLeft: "30px",
        "@media screen and (max-width: 840px)": {
          flexDirection: "column",
          marginLeft: 0,
        },
      }}
    >
      <Box //left
        sx={{
          flex: "1",
          display: "flex",
          flexDirection: "column",
          padding: "20px",
        }}
      >
        <Typography
          variant="h6"
          sx={{
            mb: "30px",
            fontSize: "2rem",
            fontWeight: "bold",
          }}
        >
          Ecommerce APP
        </Typography>
        <Typography
          variant="h6"
          sx={{
            margin: "20px 0px",
          }}
        >
          Lorem ipsum dolor sit amet, consectetur adipiscing elit. Pellentesque
          euismod, urna eu tempor consectetur, nisi nunc efficitur nunc, eu
          aliquet nunc nisi eu nisi.
        </Typography>
        <Box
          sx={{
            display: "flex",
          }}
        >
          <SocialIcon>
            <FacebookIcon />
          </SocialIcon>
          <SocialIcon>
            <TwitterIcon />
          </SocialIcon>
          <SocialIcon>
            <InstagramIcon />
          </SocialIcon>
        </Box>
      </Box>
      <Box // center
        sx={{
          flex: "1",
          padding: "20px",
          marginLeft: "30px",
          "@media screen and (max-width: 840px)": {
            marginLeft: 0,
          },
          "@media screen and (max-width: 600px)": {
            display: "none",
          },
        }}
      >
        <Typography
          variant="h6"
          sx={{
            marginBottom: "30px",
            fontSize: "2rem",
            fontWeight: "bold",
          }}
        >
          Useful Links
        </Typography>
        <List
          sx={{
            margin: "0",
            padding: "0",
            listStyle: "none",
            display: "flex",
            flexWrap: "wrap",
          }}
        >
          <ListItemContainer>Home</ListItemContainer>
          <ListItemContainer>Cart</ListItemContainer>
          <ListItemContainer>Man Fashion</ListItemContainer>
          <ListItemContainer>Woman Fashion</ListItemContainer>
          <ListItemContainer>Accessories</ListItemContainer>
          <ListItemContainer>My Account</ListItemContainer>
          <ListItemContainer>Order Tracking</ListItemContainer>
          <ListItemContainer>Wishlist</ListItemContainer>
          <ListItemContainer>Wishlist</ListItemContainer>
          <ListItemContainer>Terms</ListItemContainer>
        </List>
      </Box>
      <Box // right
        sx={{
          flex: "1",
          padding: "20px",
          "@media screen and (max-width: 600px)": {
            backgroundColor: "#fff8f8",
          },
        }}
      >
        <Typography
          variant="h6"
          sx={{
            marginBottom: "30px",
            fontSize: "2rem",
            fontWeight: "bold",
          }}
        >
          Contact Us
        </Typography>
        <Box
          sx={{
            marginBottom: "20px",
            display: "flex",
            alignItems: "center",
          }}
        >
          <LocationOnIcon
            sx={{
              marginRight: "10px",
            }}
          />
          lorem ipsum lorem
        </Box>
        <Box
          sx={{
            marginBottom: "20px",
            display: "flex",
            alignItems: "center",
          }}
        >
          <PhoneIcon
            sx={{
              marginRight: "10px",
            }}
          />
          +55 (11) 99999-9999
        </Box>
        <Box
          sx={{
            marginBottom: "20px",
            display: "flex",
            alignItems: "center",
          }}
        >
          <EmailIcon
            sx={{
              marginRight: "10px",
            }}
          />
          lorem@ipsum.com
        </Box>
        <Box>
          <img
            src="https://i.ibb.co/Qfvn4z6/payment.png"
            style={{
              width: "50%",
              marginTop: "20px",
            }}
          />
        </Box>
      </Box>
    </Box>
  );
}

export default Footer;
