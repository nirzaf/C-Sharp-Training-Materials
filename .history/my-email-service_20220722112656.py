#create an function to send email using smtp

def send_email(email, password, message):
    import smtplib

    server = smtplib.SMTP('smtp.gmail.com', 587)
    server.starttls()
    server.login(email, password)
    server.sendmail(email, email, message)
    server.quit()

#create a trigger to send email on each event
