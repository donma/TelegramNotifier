# TelegramNotifier


## 有任何問題嗎 ? 
https://facebook.com/donma.blog

## 用途
一個簡單的可以加入多個 Telegram BOTs 並且可以進行該 BOT 進行廣播

## 預設登入帳號密碼

admin / root 

可以自行在 web.config 中進行更改

## Sample

![alt Preview](https://github.com/donma/TelegramNotifier/blob/master/demo1.jpg?raw=true)

## command

/start 註冊接收廣播

/end 結束接收廣播

/test 測試

/last  最後訊息

![](https://github.com/donma/TelegramNotifier/blob/master/demo2.jpg?raw=true)


## Call Api to Broadcast

'''C#

            WebClient wc = new WebClient();
            string targetAddress ="http://"+ Request.Url.Authority + "/api/push.aspx";
            wc.Encoding = Encoding.UTF8;
            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
            NameValueCollection nc = new NameValueCollection();
            nc["token"] = txtBCToken.Text;
            nc["content"] = Server.HtmlEncode(txtContent.Text);
            nc["id"] = ddlBots.SelectedValue;
            byte[] bResult = wc.UploadValues(targetAddress, nc);
            string result = Encoding.UTF8.GetString(bResult);
            
'''
