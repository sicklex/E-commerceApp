import React from "react";
import FacebookIcon from "@mui/icons-material/Facebook";
import TwitterIcon from "@mui/icons-material/Twitter";
import InstagramIcon from "@mui/icons-material/Instagram";
import AcUnitIcon from "@mui/icons-material/AcUnit";
import { Box } from "@mui/system";
import { Link, List, ListItem } from "@mui/material";

function Footer() {
  return (
    <Box
      sx={{
        width: "50%",
        border: "1px solid #ccc",
        borderRadius: "10px",
        margin: "30px auto",
        display: "flex",
        flexDirection: "column",
        alignItems: "center",
        justifyContent: "center",
        padding: "20px",
      }}
    >
      <Box
        sx={{
          display: "flex",
          flexDirection: "row",
          justifyContent: "space-evenly",
          alignItems: "center",
          borderBottom: "1px solid #ccc",
        }}
      >
        <Box>
          <Box
            sx={{
              display: "flex",
              justifyContent: "center",
              alignItems: "center",
            }}
          >
            <AcUnitIcon /> <p>Dev E-commerce</p>
          </Box>
          <Box>
            <List
              sx={{
                display: "flex",
                flexDirection: "row",
                justifyContent: "space-evenly",
                alignItems: "center",
                gap: "10px",
              }}
            >
              <ListItem>
                <Link
                  href="#"
                  sx={{
                    textDecoration: "none",
                    fontWeight: "bold",
                  }}
                >
                  Link 1
                </Link>
              </ListItem>
              <ListItem>
                <Link
                  href="#"
                  sx={{
                    textDecoration: "none",
                    fontWeight: "bold",
                  }}
                >
                  Link 2
                </Link>
              </ListItem>
              <ListItem>
                <Link
                  href="#"
                  sx={{
                    textDecoration: "none",
                    fontWeight: "bold",
                  }}
                >
                  Link 3
                </Link>
              </ListItem>
              <ListItem>
                <Link
                  href="#"
                  sx={{
                    textDecoration: "none",
                    fontWeight: "bold",
                  }}
                >
                  Link 4
                </Link>
              </ListItem>
            </List>
            <Box
              sx={{
                width: "100%",
                margin: "0 auto",
                display: "flex",
                flexDirection: "column",
                alignItems: "center",
              }}
            >
              <List
                href="#"
                sx={{
                  display: "flex",
                  flexDirection: "row",
                  justifyContent: "space-evenly",
                  alignItems: "center",
                  gap: "20px",
                }}
              >
                <ListItem>
                  <Link href="#" sx={{ textDecoration: "none" }}>
                    <FacebookIcon />
                  </Link>
                </ListItem>
                <ListItem>
                  <Link href="#" sx={{ textDecoration: "none" }}>
                    <TwitterIcon />
                  </Link>
                </ListItem>
                <ListItem>
                  <Link href="#" sx={{ textDecoration: "none" }}>
                    <InstagramIcon />
                  </Link>
                </ListItem>
              </List>
              <Box
                sx={{
                  display: "flex",
                  justifyContent: "center",
                }}
              >
                @Lorem Ipsum
              </Box>
            </Box>
          </Box>
        </Box>
      </Box>
    </Box>
  );
}

export default Footer;
