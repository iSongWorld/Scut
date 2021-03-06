﻿/****************************************************************************
Copyright (c) 2013-2015 scutgame.com

http://www.scutgame.com

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
****************************************************************************/
using System;

namespace ZyGames.Framework.Game.Lang
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseKoreanLanguage : ILanguage
    {
        public virtual int ErrorCode { get { return 10000; } }
        public virtual int TimeoutCode { get { return 10001; } }
        public virtual int KickedOutCode { get { return 10002; } }
        public int ValidateCode { get { return 10003; } }
        public virtual string ValidateError { get { return "텍스트 내용에 포함되어, 다시 입력 해주세요!"; } }
        public virtual string ServerBusy { get { return "이제 시스템이 사용 중입니다!"; } }
        public virtual string UrlElement { get { return "요청의 매개 변수 오류입니다!"; } }

        public virtual string UrlNoParam { get { return "매개 변수 이름 : {0}이 존재하지 않습니다"; } }
        public virtual string UrlParamOutRange { get { return "매개 변수 이름 : {0} 범위를 벗어난 경우 [{1} - {2}]"; } }

        public string RequestTimeout { get { return "요청 시간 초과!"; } }
        public string ServerMaintain { get { return "서버가 유지 보수를 위해 다운!"; } }
        public virtual string ServerLoading { get { return "서버가 다시 시작됩니다 기다려주십시오 ..."; } }
        public virtual string PasswordError { get { return "당신은 계정을 입력 또는 암호가 올바르지 않습니다!"; } }
        public virtual string AcountIsLocked { get { return "계정이 잠겼습니다, ​​로그인 실패!"; } }
        public virtual string AcountNoLogin { get { return "귀하의 계정이 등록되지 않았거나 만료되었습니다!"; } }
        public virtual string AcountLogined { get { return "귀하의 계정이 다른 등록되었습니다!"; } }
        public virtual string LoadDataError { get { return "데이터를로드하지 못했습니다!"; } }
        public virtual string AppStorePayError { get { return "실패를 충전!"; } }

        public string GetAccessFailure
        {
            get { return "변호사 확보 실패!"; }
        }
    }
}